using TTC.Utils.Environment.Entities;

namespace TTC.Utils.Environment.Queries
{
    public class WmiBaseBoardQuery : WmiQueryBase
    {
        public WmiBaseBoardQuery()
            : base("Win32_BaseBoard", null, new[]
            {
                WmiBaseBoard.MANUFACTURER,
                WmiBaseBoard.PRODUCT,
                WmiBaseBoard.SERIAL_NUMBER,
            })
        {
        }
    }
}
