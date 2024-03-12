using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public void Load_ClassificatorFile(Panel progressPanel)
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

        public void Save_SpecificationFile(object[] data, string output_filename, Panel progressPanel)
        {
            // Создаю словарь, для однократного учёта деталей в общем списке
            var output_dict = new Dictionary<string, SpecificationDetail>();

            VariantType[] types = new VariantType[4];

            types[0] = VariantType.Fastening;
            types[1] = VariantType.SupportingFastening;
            types[2] = VariantType.Coupling;
            types[3] = VariantType.Cross;

            // Перебираю все данные, полученные с формы
            for (int i = 0; i < data.Length; i++)
            {
                // Преобразую один из массивов полученных данных в словарь
                // (всего 4: selected_fastenings, selected_supports, selected_couplings, selected_crosses)
                var dict = (Dictionary<string, double>)data[i];

                var type = types[i];

                // Перебираю записи типа <название варианта, количество> для каждого массива в отдельности
                foreach (KeyValuePair<string, double> pair in dict)
                {
                    // Вызываю функцию для получения всех деталей указанных в варианте
                    var detail_list = Get_VariantDetailsList(pair.Key, pair.Value, type);

                    // Перебираю детали в полученном списке
                    foreach (var detail in detail_list)
                    {
                        // Определяю, есть ли уже такая деталь в общем словаре
                        if (output_dict.TryGetValue(detail.name, out var existing_detail))
                        {
                            // Деталь есть, суммирую её значение с полученным
                            existing_detail.Add(detail.count);
                        }
                        else
                        {
                            // Детали нет, создаю запись в словаре
                            output_dict[detail.name] = detail;
                        }
                    }
                }
            }
            var output_table = FormOutputTable(output_dict.Values.ToList(), 8);
            excel.SaveFile(2, 1, 1, output_table, progressPanel, output_filename);
        }


        private DataTable FormOutputTable(List<SpecificationDetail> output_list, int columns_count)
        {
            int i;
            DataRow dr;
            DataTable outputTable = new DataTable();

            i = 0;
            while (i < columns_count)
            {
                outputTable.Columns.Add();
                i++;
            }

            string[] categories = new string[] {
                "1. Кабельная продукция",
                "2. Кроссовое оборудование",
                "3. Кабельная арматура",
                "4. Прочие материалы"
            };

            // Категория кабельное оборудование
            i = 1;
            dr = outputTable.NewRow();
            dr[1] = categories[0];
            outputTable.Rows.Add(dr);

            // Категория кроссовое оборудование
            dr = outputTable.NewRow();
            dr[1] = categories[1];
            outputTable.Rows.Add(dr);


            // Поиск и запись муфты
            var result = output_list.Find(x => x.description.ToLower().Contains("муфта"));
            if (result != null)
            {
                outputTable.Rows.Add(Get_DetailRow(outputTable, result, i));
                output_list.Remove(result);
                i++;
            }

            // Поиск и запись кросса
            result = output_list.Find(x => x.description.ToLower().Contains("кросс"));
            if (result != null)
            {
                outputTable.Rows.Add(Get_DetailRow(outputTable, result, i));
                output_list.Remove(result);
                i++;
            }

            // Категория кабельная арматура
            i = 1;
            dr = outputTable.NewRow();
            dr[1] = categories[2];
            outputTable.Rows.Add(dr);

            // Поиск и запись натяжного узла
            result = output_list.Find(x => (x.description.ToLower().Contains("узел") && x.description.ToLower().Contains("натяжной")));
            if (result != null)
            {
                outputTable.Rows.Add(Get_DetailRow(outputTable, result, i));
                output_list.Remove(result);
                i++;
            }

            // Поиск и запись поддерживающего узла
            result = output_list.Find(x => (x.description.ToLower().Contains("узел") && x.description.ToLower().Contains("поддерживающий")));
            if (result != null)
            {
                outputTable.Rows.Add(Get_DetailRow(outputTable, result, i));
                output_list.Remove(result);
                i++;
            }

            // Запись остальных деталей
            foreach (var detail in output_list)
            {
                outputTable.Rows.Add(Get_DetailRow(outputTable, detail, i));
                i++;
            }

            // Категория прочие материалы
            dr = outputTable.NewRow();
            dr[1] = categories[3];
            outputTable.Rows.Add(dr);

            return outputTable;
        }

        private DataRow Get_DetailRow(DataTable table, SpecificationDetail detail, int index)
        {
            var dr = table.NewRow();
            dr[0] = index.ToString();
            dr[1] = detail.description;
            dr[2] = detail.name;

            dr[4] = detail.vendor;
            dr[5] = detail.measure;
            dr[6] = detail.count.ToString();
            return dr;
        }

        /// <summary>
        /// Функция для получения списка деталей
        /// для указанного варианта и умножения количества его деталей на число
        /// </summary>
        /// <param name="var_name">Название варианта</param>
        /// <param name="mult">Множитель количества</param>
        /// <param name="type">Тип устройства для формирования списка деталей</param>
        /// <returns>Список деталей, с количеством, помноженным на множитель</returns>
        /// 
        private List<SpecificationDetail> Get_VariantDetailsList(string var_name, double mult, VariantType type)
        {
            var variant = GetSpecificationVariant(var_name, type);
            if (variant == null) return null;

            var list = new List<SpecificationDetail>();

            foreach (var detail in variant.GetDetails())
            {
                var new_detail = new SpecificationDetail(detail);
                new_detail.Multiply(mult);
                list.Add(new_detail);
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
                if (!int.TryParse(detail_name.Substring(2), out int var_number))
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
                if (variant.variant == var_type)
                    if (variant.name == name)
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
        /// <param name="type">Тип варианта</param>
        /// <returns>Найденный объект класса SpecificationVariant или null</returns>
        private SpecificationVariant GetSpecificationVariant(string name, VariantType type)
        {
            foreach (SpecificationVariant variant in variants_list)
            {
                if (variant.name == name && variant.variant == type) return variant;
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
