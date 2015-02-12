using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication.Hdd
{
    [XmlInclude(typeof(LGHdd))]
    [XmlInclude(typeof(SamsungHdd))]
    public class Hdd
    {
        public string producer { get; set; }
    }
}
