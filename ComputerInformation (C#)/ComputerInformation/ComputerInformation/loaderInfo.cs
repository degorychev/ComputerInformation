using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace ComputerInformation
{
    static class loaderInfo
    {
        private static void GetProperties(ManagementObject sysInfo, ref JObject jsonMessage)
        {
            foreach (var property in sysInfo.Properties)
            {
                if (property.IsArray)
                {
                    var values = property.Value as string[];
                    jsonMessage.Add(property.Name, values != null ? string.Join(",", values) : "");
                }
                else
                {
                    jsonMessage.Add(property.Name, property.Value != null ? property.Value.ToString() : string.Empty);
                }
            }
        }
        public static string loadCPU()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }

        public static string loadMotherBoard()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_MotherboardDevice").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }
        public static string loadRAM()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_ComputerSystem").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }
        public static string loadGraphicCard()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_VideoController").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }
        public static string loadSoftware()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }
        public static string loadDiskDrive()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_DiskDrive").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }
        public static string loadDevices()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_PnPSignedDriver").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }
        public static string loadRAM2()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_PhysicalMemory").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }

        public static string loadNetwork()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_NetworkAdapterConfiguration").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output.ToString();
        }

        public static string loadSoft()
        {
            RegistryKey key;

            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            var output = new Newtonsoft.Json.Linq.JArray();

            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                softInfo si = new softInfo { DisplayName = subkey.GetValue("DisplayName") as string, InstallLocation = subkey.GetValue("InstallLocation") as string };
                if (si.DisplayName == null)
                    continue;
                output.Add(JObject.FromObject(si));
            }
            return output.ToString();
        }




        private static JArray _loadCPU()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }

        private static JArray _loadMotherBoard()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_MotherboardDevice").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }
        private static JArray _loadRAM()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_ComputerSystem").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }
        private static JArray _loadGraphicCard()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_VideoController").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }
        private static JArray _loadSoftware()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }
        private static JArray _loadDiskDrive()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_DiskDrive").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }
        private static JArray _loadDevices()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_PnPSignedDriver").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }
        private static JArray _loadRAM2()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_PhysicalMemory").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }

        private static JArray _loadNetwork()
        {
            var output = new Newtonsoft.Json.Linq.JArray();
            var objs = new ManagementObjectSearcher("select * from Win32_NetworkAdapterConfiguration").Get().Cast<ManagementObject>();
            foreach (var obj in objs)
            {
                var jsonMessage = new Newtonsoft.Json.Linq.JObject();
                GetProperties(obj, ref jsonMessage);
                output.Add(jsonMessage);
            }
            return output;
        }

        private static JArray _loadSoft()
        {
            RegistryKey key;

            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            var output = new Newtonsoft.Json.Linq.JArray();

            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                softInfo si = new softInfo { DisplayName = subkey.GetValue("DisplayName") as string, InstallLocation = subkey.GetValue("InstallLocation") as string };
                if (si.DisplayName == null)
                    continue;
                output.Add(JObject.FromObject(si));
            }
            return output;
        }

        public static string megaExport()
        {
            keyValue CPU = new keyValue { key = "CPU", value = _loadCPU() };
            keyValue MotherBoard = new keyValue { key = "MotherBoard", value = _loadMotherBoard() };
            keyValue RAM = new keyValue { key = "RAM", value = _loadRAM() };
            keyValue GraphicCard = new keyValue { key = "GraphicCard", value = _loadGraphicCard() };
            keyValue Software = new keyValue { key = "Software", value = _loadSoftware() };
            keyValue DiskDrive = new keyValue { key = "DiskDrive", value = _loadDiskDrive() };
            keyValue Devices = new keyValue { key = "Devices", value = _loadDevices() };
            keyValue RAM2 = new keyValue { key = "RAM2", value = _loadRAM2() };
            keyValue Network = new keyValue { key = "Network", value = _loadNetwork() };
            keyValue Soft = new keyValue { key = "Soft", value = _loadSoft() };
            
            List<keyValue> export = new List<keyValue>();
            export.Add(CPU);
            export.Add(MotherBoard);
            export.Add(RAM);
            export.Add(GraphicCard);
            export.Add(Software);
            export.Add(DiskDrive);
            export.Add(Devices);
            export.Add(RAM2);
            export.Add(Network);
            export.Add(Soft);
            var jt = JToken.FromObject(export);
            return jt.ToString();
        }
    }
    struct softInfo
    {
        public string DisplayName;
        public string InstallLocation;
    }

    struct keyValue
    {
        public string key;
        public JArray value;
    }
}
