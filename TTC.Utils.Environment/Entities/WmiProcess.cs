namespace TTC.Utils.Environment.Entities
{
    public class WmiProcess
    {
        internal const string COMMAND_LINE = "CommandLine";
        internal const string NAME = "Name";
        internal const string EXECUTABLE_PATH = "ExecutablePath";
        internal const string PROCESS_ID = "SIDType";
        internal const string PARENT_PROCESS_ID = "ParentProcessId";

        // ReSharper disable UnusedAutoPropertyAccessor.Local
        [WmiResult(COMMAND_LINE)]
        public string CommandLine { get; private set; }

        [WmiResult(NAME)]
        public string Name { get; private set; }

        [WmiResult(EXECUTABLE_PATH)]
        public string ExecutablePath { get; private set; }

        [WmiResult(PROCESS_ID)]
        public int ProcessId { get; private set; }
        
        [WmiResult(PARENT_PROCESS_ID)]
        public int ParentProcessId { get; private set; }
        // ReSharper restore UnusedAutoPropertyAccessor.Local
    }
}
