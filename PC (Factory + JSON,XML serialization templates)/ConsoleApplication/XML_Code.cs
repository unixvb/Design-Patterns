using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication
{
    public class XML_Code : ICode
    {
        public string Serialize<T>(T jsonObject)
        {
            XmlSerializer serializer = new XmlSerializer(jsonObject.GetType());
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, jsonObject);
                return writer.ToString();
            }
        }
    }
}
