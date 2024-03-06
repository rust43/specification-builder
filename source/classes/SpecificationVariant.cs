using System.Collections.Generic;

namespace SpecificationBuilder
{
    public enum VariantType
    {
        Fastening,
        SupportingFastening,
        Coupling,
        Cross,
        Undefined
    }

    public class SpecificationVariant
    {
        private string _name;
        private int _number;
        //private string _type;
        private VariantType _variant;
        private List<SpecificationDetail> _details;

        public SpecificationVariant(int number, VariantType variant)
        {
            _number = number;
            _variant = variant;
            _name = $"Вариант {number}";
            _details = new List<SpecificationDetail>();
            //if (variant == Variant.Fastening)
            //    _type = "Натяжное крепление";
            //else if (variant == Variant.SupportingFastening)
            //    _type = "Поддерживающее крепление";
            //else if (variant == Variant.Coupling)
            //    _type = "Муфта";
            //else if (variant == Variant.Cross)
            //    _type = "Кросс";
            //else
            //    _type = "Не определен";
        }

        public void AddDetail(SpecificationDetail detail)
        {
            _details.Add(detail);
        }

        public IEnumerable<SpecificationDetail> GetDetails()
        {
            return _details.ToArray();
        }

        public string name { get { return _name; } }

        public VariantType GetVariant { get { return _variant; } }
    }

    public class SpecificationDetail
    {
        // Внутренние переменные класса
        private string _name;
        private string _description;
        private string _vendor;
        private string _measure;
        private double _count;

        // Конструктор класса
        public SpecificationDetail(string name, string description, string vendor, string measure, double count)
        {
            _name = name;
            _description = description;
            _vendor = vendor;
            _measure = measure;
            _count = count;
        }

        public SpecificationDetail(SpecificationDetail other)
        {
            _name = other._name;
            _description = other._description;
            _vendor = other._vendor;
            _measure = other._measure;
            _count = other._count;
        }

        // Функция для умножения количества с множителем
        public void Multiply(double mult)
        {
            _count *= mult;
        }

        // Функция для сложения количества с числом
        public void Add(double count)
        {
            _count += count;
        }

        // Функции для получения значений внутренних переменных
        public string name { get { return _name; } }
        public string description { get { return _description; } }
        public string vendor { get { return _vendor; } }
        public string measure { get { return _measure; } }
        public double count { get { return _count; } }
    }
}
