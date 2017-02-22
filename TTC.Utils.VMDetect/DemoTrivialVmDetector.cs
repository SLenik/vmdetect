using TTC.Utils.Environment.Entities;
using TTC.Utils.Environment.Interfaces;
using TTC.Utils.Environment.Queries;

namespace TTC.Utils.VMDetect
{
    /// <summary>
    /// Тестовый класс для проверки запуска из-под ВМ.
    /// </summary>
    class DemoTrivialVmDetector
    {
        private readonly IWmiService _wmiService;

        public DemoTrivialVmDetector(IWmiService wmiService)
        {
            _wmiService = wmiService;
        }
        public MachineType GetMachineType()
        {
            var wmiProcessor = _wmiService.QueryFirst<WmiProcessor>(new WmiProcessorQuery());
            if (wmiProcessor.Manufacturer != null)
            {
                if (wmiProcessor.Manufacturer.Contains("VBoxVBoxVBox"))
                    return MachineType.VirtualBox;
                if (wmiProcessor.Manufacturer.Contains("VMwareVMware"))
                    return MachineType.VMWare;
                if (wmiProcessor.Manufacturer.Contains("prl hyperv"))
                    return MachineType.Parallels;
            }

            var wmiBaseBoard = _wmiService.QueryFirst<WmiBaseBoard>(new WmiBaseBoardQuery());
            if (wmiBaseBoard.Manufacturer != null)
            {
                if (wmiBaseBoard.Manufacturer.Contains("Microsoft Corporation"))
                    return MachineType.HyperV;
            }

            var wmiDiskDrives = _wmiService.QueryAll<WmiDiskDrive>(new WmiDiskDriveQuery());
            if (wmiDiskDrives != null)
                foreach (var wmiDiskDrive in wmiDiskDrives)
                {
                    if (wmiDiskDrive.PnpDeviceId.Contains("VBOX_HARDDISK"))
                        return MachineType.VirtualBox;
                    if (wmiDiskDrive.PnpDeviceId.Contains("VEN_VMWARE"))
                        return MachineType.VMWare;
                }

            return MachineType.Unknown;
        }
    }
}
