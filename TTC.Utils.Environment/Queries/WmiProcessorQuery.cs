using TTC.Utils.Environment.Entities;

namespace TTC.Utils.Environment.Queries
{
    public class WmiProcessorQuery : WmiQueryBase
    {
        public WmiProcessorQuery()
            : base("Win32_Processor", null, new[]
            {
                WmiProcessor.MANUFACTURER,
                WmiProcessor.CAPTION,
                WmiProcessor.NAME,
                WmiProcessor.PROCESSOR_ID,
                WmiProcessor.NUM_OF_CORES,
                WmiProcessor.NUM_OF_LOGICAL_PROCESSORS,
                WmiProcessor.L2_CACHE_SIZE,
                WmiProcessor.L3_CACHE_SIZE,
                WmiProcessor.SOCKET_DESIGNATION,
            })
        {
        }
    }
}
