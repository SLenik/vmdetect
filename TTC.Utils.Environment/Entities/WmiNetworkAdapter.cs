using System;

namespace TTC.Utils.Environment.Entities
{
    public class WmiNetworkAdapter
    {
        internal const string PNP_DEVICE_ID = "PNPDeviceID";
        internal const string GUID = "GUID";
        internal const string MAC_ADDRESS = "MACAddress";

        // ReSharper disable UnusedAutoPropertyAccessor.Local
        [WmiResult(PNP_DEVICE_ID)]
        public string PnpDeviceId { get; private set; }

        [WmiResult(GUID)]
        public Guid? Guid { get; private set; }

        [WmiResult(MAC_ADDRESS)]
        public string MacAddress { get; private set; }
        // ReSharper restore UnusedAutoPropertyAccessor.Local
    }
}
