namespace TTC.Utils.Environment.Entities
{
    public class WmiProcessor
    {
        internal const string MANUFACTURER = "Manufacturer";
        internal const string CAPTION = "Caption";
        internal const string NAME = "Name";
        internal const string PROCESSOR_ID = "ProcessorId";
        internal const string NUM_OF_CORES = "NumberOfCores";
        internal const string NUM_OF_LOGICAL_PROCESSORS = "NumberOfLogicalProcessors";
        internal const string L2_CACHE_SIZE = "L2CacheSize";
        internal const string L3_CACHE_SIZE = "L3CacheSize";
        internal const string SOCKET_DESIGNATION = "SocketDesignation";

        // ReSharper disable UnusedAutoPropertyAccessor.Local
        [WmiResult(MANUFACTURER)]
        public string Manufacturer { get; private set; }

        [WmiResult(CAPTION)]
        public string Caption { get; private set; }

        [WmiResult(NAME)]
        public string Name { get; private set; }

        [WmiResult(PROCESSOR_ID)]
        public string ProcessorId { get; private set; }

        [WmiResult(NUM_OF_CORES)]
        public int? NumberOfCores { get; private set; }

        [WmiResult(NUM_OF_LOGICAL_PROCESSORS)]
        public int? NumberOfLogicalProcessors { get; private set; }

        [WmiResult(L2_CACHE_SIZE)]
        public int? L2CacheSize { get; private set; }

        [WmiResult(L3_CACHE_SIZE)]
        public int? L3CacheSize { get; private set; }

        [WmiResult(SOCKET_DESIGNATION)]
        public string SocketDesignation { get; private set; }
        // ReSharper restore UnusedAutoPropertyAccessor.Local
    }
}
