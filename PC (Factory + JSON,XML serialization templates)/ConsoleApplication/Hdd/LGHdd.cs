using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Hdd
{
    [Serializable]
    public class LGHdd : Hdd
    {
        public LGHdd()
        {
            producer = "LG";
        }
    }
}
