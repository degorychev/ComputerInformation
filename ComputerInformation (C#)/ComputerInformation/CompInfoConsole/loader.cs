using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace CompInfoConsole
{
    public static class loader
    {
        public static HWSW loadCPU()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>());
            return output;
        }
        public static HWSW loadMotherBoard()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_MotherboardDevice").Get().Cast<ManagementObject>());
            return output;
        }
        public static HWSW loadRAM()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_ComputerSystem").Get().Cast<ManagementObject>());
            return output;
        }
        public static HWSW loadGraphicCard()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_VideoController").Get().Cast<ManagementObject>());
            return output;
        }
        public static HWSW loadSoftware()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get().Cast<ManagementObject>());
            return output;
        }
        public static HWSW loadDiskDrive()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_DiskDrive").Get().Cast<ManagementObject>());
            return output;
        }
        public static HWSW loadDevices()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_PnPSignedDriver").Get().Cast<ManagementObject>());
            return output;
        }
        public static HWSW loadRAM2()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_PhysicalMemory").Get().Cast<ManagementObject>());
            return output;
        }
        public static HWSW loadNetwork()
        {
            var output = new HWSW(new ManagementObjectSearcher("select * from Win32_NetworkAdapterConfiguration").Get().Cast<ManagementObject>());
            return output;
        }
    }
}
