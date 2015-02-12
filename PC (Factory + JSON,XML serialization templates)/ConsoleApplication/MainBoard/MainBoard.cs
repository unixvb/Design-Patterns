using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication.MainBoard
{
    [XmlInclude(typeof(AsusMainBoard))]
    [XmlInclude(typeof(MSIMainBoard))]
    public class MainBoard
    {
        public string producer { get; set; }
    }
}
