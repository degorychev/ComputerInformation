using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInformation
{
    public class HWSW //Типа HardWare_SoftWare
    {
        List<Dictionary<string, string>> M_objects = new List<Dictionary<string, string>>();

        public HWSW(IEnumerable<ManagementObject> objects)
        {
            foreach (var obj in objects)
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach (var property in obj.Properties)
                {
                    if (!property.IsArray)
                        values.Add(property.Name, property.Value != null ? property.Value.ToString() : string.Empty);
                    else
                    {
                        var property_values = property.Value as string[];
                        values.Add(property.Name, property_values != null ? string.Join(",", property_values) : "");
                    }
                }
                M_objects.Add(values);
            }
        }

        public string print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Объектов: " + M_objects.Count.ToString());
            int i = 0;
            foreach(var obj in M_objects)
            {
                sb.AppendLine(String.Format("Объект №" + i++));
                foreach(var value in obj.Keys)
                {
                    sb.AppendLine(String.Format("{0}: {1}", value, obj[value]));
                }
            }
            return sb.ToString();
        }
    }
}
