using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication
{
    [XmlInclude(typeof(SilverBox))]
    [XmlInclude(typeof(BlackBox))]
    public class Box
    {
        public string color { get; set; }
    }
}
