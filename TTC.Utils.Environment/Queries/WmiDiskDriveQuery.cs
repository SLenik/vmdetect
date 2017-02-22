using TTC.Utils.Environment.Entities;

namespace TTC.Utils.Environment.Queries
{
    public class WmiDiskDriveQuery : WmiQueryBase
    {
        public WmiDiskDriveQuery()
            : base("Win32_DiskDrive", null, new[]
            {
                WmiDiskDrive.DEVICE_ID,
                WmiDiskDrive.MEDIA_TYPE,
                WmiDiskDrive.MODEL,
                WmiDiskDrive.PNP_DEVICE_ID,
                WmiDiskDrive.SERIAL_NUMBER,
            })
        {
        }
    }
}
