using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Memory
{
    [Serializable]
    public class Ddr2Memory : Memory
    {
        public Ddr2Memory()
        {
            type = "DDR2";
        }
    }
}
