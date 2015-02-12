using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Processor
{
    [Serializable]
    public class AMDProcessor : Processor
    {
        public AMDProcessor()
        {
            producer = "AMD";
        }
    }
}
