using TTC.Utils.Environment.Entities;

namespace TTC.Utils.Environment.Queries
{
    public class WmiNetworkAdapterQuery : WmiQueryBase
    {
        private static readonly string[] COLUMN_NAMES =
            {
                WmiNetworkAdapter.GUID,
                WmiNetworkAdapter.MAC_ADDRESS,
                WmiNetworkAdapter.PNP_DEVICE_ID,
            };

        public WmiNetworkAdapterQuery(WmiNetworkAdapterType adapterType = WmiNetworkAdapterType.All)
            : base("Win32_NetworkAdapter", null, COLUMN_NAMES)
        {
            if (adapterType == WmiNetworkAdapterType.Physical)
                SelectQuery.Condition = "PhysicalAdapter=1";
            else if (adapterType == WmiNetworkAdapterType.Virtual)
                SelectQuery.Condition = "PhysicalAdapter=0";
        }
    }
}
