using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication.Processor
{
    [XmlInclude(typeof(AMDProcessor))]
    [XmlInclude(typeof(IntelProcessor))]
    public class Processor
    {
        public string producer { get; set; }
    }
}
