using System.Collections.Generic;
using System.Linq;
using TTC.Utils.Environment.Entities;

namespace TTC.Utils.Environment.Queries
{
    public class WmiProcessQuery : WmiQueryBase
    {
        private static readonly string[] COLUMN_NAMES =
            {
                WmiProcess.COMMAND_LINE,
                WmiProcess.NAME,
                WmiProcess.EXECUTABLE_PATH,
                WmiProcess.PROCESS_ID,
                WmiProcess.PARENT_PROCESS_ID,
            };

        public WmiProcessQuery()
            : base("Win32_Process", null, COLUMN_NAMES)
        {
        }

        public WmiProcessQuery(IEnumerable<string> processNames)
            : this()
        {
            SelectQuery.Condition = 
                string.Join(" OR ", processNames.Select(processName => $"Name LIKE '%{processName}%'"));
        }
    }
}
