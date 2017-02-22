namespace TTC.Utils.Environment.Entities
{
    public class WmiDiskDrive
    {
        internal const string DEVICE_ID = "DeviceID";
        internal const string MEDIA_TYPE = "MediaType";
        internal const string MODEL = "Model";
        internal const string PNP_DEVICE_ID = "PNPDeviceID";
        internal const string SERIAL_NUMBER = "SerialNumber";

        // ReSharper disable UnusedAutoPropertyAccessor.Local
        [WmiResult(DEVICE_ID)]
        public string DeviceId { get; private set; }

        [WmiResult(MEDIA_TYPE)]
        public string MediaType { get; private set; }

        [WmiResult(MODEL)]
        public string Model { get; private set; }

        [WmiResult(PNP_DEVICE_ID)]
        public string PnpDeviceId { get; private set; }

        [WmiResult(SERIAL_NUMBER)]
        public string SerialNumber { get; private set; }
        // ReSharper restore UnusedAutoPropertyAccessor.Local
    }
}
