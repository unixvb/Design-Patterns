using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class PCConfigurator
    {
        public IPCFactory PCFactory { get; set; }
        public void Configurate(PC Pc)
        {
            Pc.Box = PCFactory.CreateBox();
            Pc.Hdd = PCFactory.CreateHdd();
            Pc.MainBoard = PCFactory.CreateMainBoard();
            Pc.Memory = PCFactory.CreateMemory();
            Pc.Processor = PCFactory.CreateProcessor();
        }
    }
}
