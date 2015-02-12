using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication.Memory
{
    [XmlInclude(typeof(Ddr2Memory))]
    [XmlInclude(typeof(DdrMemory))]
    public class Memory
    {
        public string type { get; set; }
    }
}
