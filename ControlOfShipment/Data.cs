namespace ControlOfShipment
{
    public class Data
    {
        public string Value { get; set; }
        public int Count { get; set; }

        public Data (string value)
        {
            Value = value;
            Count = 1;
        }
    }
}
