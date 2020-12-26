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
            var jsonMessage = new Newtonsoft.Json.Linq.JObject();
            var cpu = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>().First();
            GetProperties(cpu, ref jsonMessage);
            return jsonMessage.ToString();
        }
        public static string loadMotherBoard()
        {
            var jsonMessage1 = new Newtonsoft.Json.Linq.JObject();
            var cpu = new ManagementObjectSearcher("select * from Win32_MotherboardDevice").Get().OfType<ManagementObject>().FirstOrDefault(); ;
            GetProperties(cpu, ref jsonMessage1);

            ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
            scope.Connect();
            var jsonMessage2 = new Newtonsoft.Json.Linq.JObject();
            ManagementObject wmiClass = new ManagementObject(scope, new ManagementPath("Win32_BaseBoard.Tag=\"Base Board\""), new ObjectGetOptions());
            GetProperties(wmiClass, ref jsonMessage2);
            return jsonMessage1.ToString() + "\n================\n" + jsonMessage2.ToString();
        }
        public static string loadRAM()
        {
            var jsonMessage = new Newtonsoft.Json.Linq.JObject();
            var cpu = new ManagementObjectSearcher("select * from Win32_ComputerSystem").Get().Cast<ManagementObject>().First();
            GetProperties(cpu, ref jsonMessage);
            return jsonMessage.ToString();
        }
        public static string loadGraphicCard()
        {
            var jsonMessage = new Newtonsoft.Json.Linq.JObject();
            var cpu = new ManagementObjectSearcher("select * from Win32_VideoController").Get().Cast<ManagementObject>().First();
            GetProperties(cpu, ref jsonMessage);
            return jsonMessage.ToString();
        }
        public static string loadSoftware()
        {
            var jsonMessage = new Newtonsoft.Json.Linq.JObject();
            var obj = new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get().Cast<ManagementObject>().First();
            GetProperties(obj, ref jsonMessage);            
            return jsonMessage.ToString();

        }
        public static string loadDevices()
        {
            var jsonMessage = new Newtonsoft.Json.Linq.JObject();
            var cpu = new ManagementObjectSearcher("select * from Win32_PnPSignedDriver").Get().Cast<ManagementObject>().First();
            GetProperties(cpu, ref jsonMessage);
            return jsonMessage.ToString();
        }
    }
}
