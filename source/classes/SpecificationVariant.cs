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
            SpecificationDetail[] allDetails = _details.ToArray();
            return allDetails;
        }

        public string GetName { get { return _name; } }

        public VariantType GetVariant { get { return _variant; } }
    }

    public class SpecificationDetail
    {
        private string _name;
        private string _description;
        private string _vendor;
        private string _measure;
        private int _count;

        public SpecificationDetail(string name, string description, string vendor, string measure, int count)
        {
            _name = name;
            _description = description;
            _vendor = vendor;
            _measure = measure;
            _count = count;
        }
    }
}
