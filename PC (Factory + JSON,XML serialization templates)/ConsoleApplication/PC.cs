using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication
{
    public class PC
    {
        public Box Box { get; set; }
        public ConsoleApplication.Processor.Processor Processor { get; set; }
        public ConsoleApplication.MainBoard.MainBoard MainBoard { get; set; }
        public ConsoleApplication.Hdd.Hdd Hdd { get; set; }
        public ConsoleApplication.Memory.Memory Memory { get; set; }
    }
}
