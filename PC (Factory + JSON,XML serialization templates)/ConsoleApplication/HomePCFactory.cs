using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class HomePCFactory : IPCFactory
    {
        public Box CreateBox()
        {
            return new SilverBox();
        }

        public Processor.Processor CreateProcessor()
        {
            return new Processor.IntelProcessor();
        }

        public MainBoard.MainBoard CreateMainBoard()
        {
            return new MainBoard.MSIMainBoard();
        }

        public Hdd.Hdd CreateHdd()
        {
            return new Hdd.SamsungHdd();
        }

        public Memory.Memory CreateMemory()
        {
            return new Memory.Ddr2Memory();
        }
    }
}
