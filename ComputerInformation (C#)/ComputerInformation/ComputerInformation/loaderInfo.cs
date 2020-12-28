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
    }
    struct softInfo
    {
        public string DisplayName;
        public string InstallLocation;
    }
}
