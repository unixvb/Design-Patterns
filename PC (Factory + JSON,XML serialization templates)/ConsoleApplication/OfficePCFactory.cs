using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class OfficePCFactory : IPCFactory
    {
        public Box CreateBox()
        {
            return new BlackBox();
        }

        public Processor.Processor CreateProcessor()
        {
            return new Processor.AMDProcessor();
        }

        public MainBoard.MainBoard CreateMainBoard()
        {
            return new MainBoard.AsusMainBoard();
        }

        public Hdd.Hdd CreateHdd()
        {
            return new Hdd.LGHdd();
        }

        public Memory.Memory CreateMemory()
        {
            return new Memory.DdrMemory();
        }
    }
}
