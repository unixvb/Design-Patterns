using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Processor
{
    [Serializable]
    public class IntelProcessor : Processor
    {
        public IntelProcessor()
        {
            producer = "Intel";
        }
    }
}
