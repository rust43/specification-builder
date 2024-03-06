using System;
using System.Data;
using System.Collections.Generic;

namespace SpecificationBuilder
{
    public class ClassificatorFile
    {
        private string filename;
        private int page;
        private int c1, r1, c2, r2;
        private DataTable inputTable;
        private ExcelManager excel;
        private List<string[]> parsed_list;
        private List<SpecificationVariant> variants_list;
        private Logger logger;

        public ClassificatorFile(ExcelManager excel, Logger logger, string filename)
        {
            page = 1;
            c1 = 1;
            r1 = 1;
            c2 = -1;
            r2 = -1;

            this.excel = excel;
            this.filename = filename;
            this.logger = logger;
        }

        public void Load_ClassificatorFile(System.Windows.Forms.Panel progressPanel)
        {
            try
            {
                inputTable = excel.LoadFile(filename, page, progressPanel, c1, r1, c2, r2);
            }
            catch (Exception e)
            {
                logger.AppendToLog("Ошибка при открытии файла: \"" + GetFileName + "\": " + e.Message, LogLevel.Error);
            }
            try
            {
                Parse_InputTable();
            }
            catch (Exception e)
            {
                logger.AppendToLog("Ошибка при чтении файла: " + e.Message, LogLevel.Error);
            }
            try
            {
                Fill_Variants();
            }
            catch (Exception e)
            {
                logger.AppendToLog("Ошибка при формировании вариантов: " + e.Message, LogLevel.Error);
            }
        }

        public void Save_SpecificationFile(object[] data)
        {
            List<SpecificationDetail> output_list = new List<SpecificationDetail>();

            for (int i = 0; i < data.Length; i++)
            {
                var dict = (Dictionary<string, double>)data[i];

                foreach (KeyValuePair<string, double> pair in dict)
                {
                    output_list.AddRange(Get_VariantDetailsList(pair.Key, pair.Value));
                }
            }
        }

        private List<SpecificationDetail> Get_VariantDetailsList(string var_name, double count)
        {
            var variant = GetSpecificationVariant(var_name);
            if (variant == null) return null;

            var list = new List<SpecificationDetail>();

            foreach (var detail in variant.GetDetails())
            {
                var new_detail_line = detail;
                new_detail_line.Multiply(count);
                list.Add(new_detail_line);
            }

            return list;
        }

        private void Parse_InputTable()
        {
            if (inputTable == null) return;

            if (parsed_list != null) parsed_list.Clear();

            parsed_list = new List<string[]>();

            for (int i = 0; i < inputTable.Rows.Count; i++)
            {
                try
                {
                    var items = inputTable.Rows[i].ItemArray;

                    if (items[0] == null || items[0].ToString() == "") continue;

                    string[] values = new string[items.Length];

                    for (int j = 0; j < items.Length; j++)
                        values[j] = items[j].ToString();

                    parsed_list.Add(values);
                }
                catch (Exception error)
                {
                    logger.AppendToLog("Ошибка при чтении файла на строке: \"" + inputTable.Rows[i].ToString() + "\". " + error.Message, LogLevel.Error);
                }
            }
            inputTable.Clear();
            inputTable = null;
        }

        private void Fill_Variants()
        {
            if (parsed_list == null) return;
            if (variants_list != null) variants_list.Clear();
            variants_list = new List<SpecificationVariant>();

            foreach (string[] detail_record in parsed_list)
            {
                // Определяю тип варианта (Крепление, Поддерживающее крепление, муфта, кросс)
                string detail_name = detail_record[0].ToUpper();
                VariantType var_type;
                if (detail_name.StartsWith("N"))
                    var_type = VariantType.Fastening;
                else if (detail_name.StartsWith("P") || detail_name.StartsWith("Р"))
                    var_type = VariantType.SupportingFastening;
                else if (detail_name.StartsWith("M") || detail_name.StartsWith("М"))
                    var_type = VariantType.Coupling;
                else if (detail_name.StartsWith("K") || detail_name.StartsWith("К"))
                    var_type = VariantType.Cross;
                else
                    var_type = VariantType.Undefined;

                // Определяю указанный номер варианта
                int var_number;
                if (!int.TryParse(detail_name.Substring(2), out var_number))
                    continue;

                // Определяю количество деталей
                if (!double.TryParse(detail_record[7], out double count))
                    count = 0;

                // Ищу есть ли уже такой вариант
                SpecificationVariant variant = GetOrCreateSpecificationVariant(var_type, var_number);

                // Создаю новую запись о детали
                SpecificationDetail detail = new SpecificationDetail(
                    detail_record[3],
                    detail_record[2],
                    detail_record[5],
                    detail_record[6],
                    count
                );

                // Добавляю деталь в найденный вариант
                variant.AddDetail(detail);
            }

            parsed_list.Clear();
            parsed_list = null;
        }


        /// <summary>
        /// Функция возвращает вариант, если таковой имеется в списке. Если нет, то создает новый и возвращает его.
        /// </summary>
        /// <param name="var_type">Тип варианта</param>
        /// <param name="number">Номер варианта</param>
        /// <returns>Объект класса SpecificationVariant</returns>
        private SpecificationVariant GetOrCreateSpecificationVariant(VariantType var_type, int number)
        {
            string name = $"Вариант {number}";
            foreach (SpecificationVariant variant in variants_list)
            {
                if (variant.GetVariant == var_type)
                    if (variant.GetName == name)
                        // Есть такой вариант, возвращаем его
                        return variant;
            }
            // Нет такого варианта, создаем новый
            SpecificationVariant new_variant = new SpecificationVariant(number, var_type);
            variants_list.Add(new_variant);
            return new_variant;
        }


        /// <summary>
        /// Функция возвращает вариант, если таковой имеется в списке. Если нет, то возвращает null.
        /// </summary>
        /// <param name="name">Наименование варианта</param>
        /// <returns>Найденный объект класса SpecificationVariant или null</returns>
        private SpecificationVariant GetSpecificationVariant(string name)
        {
            foreach (SpecificationVariant variant in variants_list)
            {
                if (variant.GetName == name) return variant;
            }
            return null;
        }

        public IEnumerable<SpecificationVariant> GetSpecificationVariants()
        {
            return variants_list;
        }

        public string GetFileName { get { return System.IO.Path.GetFileName(filename); } }

        public string GetFilePath { get { return filename; } }
    }
}
