namespace TTC.Utils.Environment.Entities
{
    public class WmiBaseBoard
    {
        internal const string MANUFACTURER = "Manufacturer";
        internal const string PRODUCT = "Product";
        internal const string SERIAL_NUMBER = "SerialNumber";

        // ReSharper disable UnusedAutoPropertyAccessor.Local
        [WmiResult(MANUFACTURER)]
        public string Manufacturer { get; private set; }

        [WmiResult(PRODUCT)]
        public string Product { get; private set; }

        [WmiResult(SERIAL_NUMBER)]
        public string SerialNumber { get; private set; }
        // ReSharper restore UnusedAutoPropertyAccessor.Local
    }
}
