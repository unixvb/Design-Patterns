using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    [Serializable]
    public class BlackBox : Box
    {
       public BlackBox()
        {
            color = "black";
        }
    }
}
