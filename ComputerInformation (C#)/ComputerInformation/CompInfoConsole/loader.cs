using Microsoft.Win32;
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
        public static HWSW loadOS()
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

        public static HWSW loadSoftWare()
        {
            List<Dictionary<string, string>> softwares = new List<Dictionary<string, string>>();
            RegistryKey key;
            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");

            foreach (String keyName in key.GetSubKeyNames())
            {
                Dictionary<string, string> software = new Dictionary<string, string>();

                RegistryKey subkey = key.OpenSubKey(keyName);
                software.Add("DisplayName", subkey.GetValue("DisplayName") as string);
                software.Add("InstallLocation", subkey.GetValue("InstallLocation") as string);
                if (subkey.GetValue("DisplayName") as string == null)
                    continue;
                softwares.Add(software);
            }
            return new HWSW(softwares);
        }
    }
}
