using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Memory
{
    [Serializable]
    public class DdrMemory : Memory
    {
        public DdrMemory()
        {
            type = "DDR";
        }
    }
}
