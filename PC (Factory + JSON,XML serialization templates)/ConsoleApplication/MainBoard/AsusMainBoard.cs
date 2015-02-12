using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.MainBoard
{
    [Serializable]
    public class AsusMainBoard : MainBoard
    {
        public AsusMainBoard()
        {
            producer = "Asus";
        }
    }
}
