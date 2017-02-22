using System;
using TTC.Utils.Environment.Services;

namespace TTC.Utils.VMDetect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка запуска приложения в ОС в виртуальной машине");
            Console.WriteLine();

            // ToDo: DI-контейнер
            var vmDetector = new DemoTrivialVmDetector(new WmiService());

            Console.WriteLine(vmDetector.GetMachineType());
        }
    }
}
