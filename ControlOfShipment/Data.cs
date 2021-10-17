using System.ComponentModel;

namespace ControlofShipmentModel
{
    public class Data
    {
        [DisplayName("Наименование")]
        public string Value { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }

        public Data (string value)
        {
            Value = value;
            Count = 1;
        }
    }
}
