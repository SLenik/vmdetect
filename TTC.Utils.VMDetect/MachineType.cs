namespace TTC.Utils.VMDetect
{
    public enum MachineType
    {
        /// <summary>
        /// Незивестный тип ВМ или программа запущена на физической машине.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// Виртуальная машина VMWare.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        VMWare,

        /// <summary>
        /// Виртуальная машина VirtualBox.
        /// </summary>
        VirtualBox,

        /// <summary>
        /// Виртуальная машина Parallels.
        /// </summary>
        Parallels,

        /// <summary>
        /// Виртуальная машина Hyper-V.
        /// </summary>
        HyperV
    }
}
