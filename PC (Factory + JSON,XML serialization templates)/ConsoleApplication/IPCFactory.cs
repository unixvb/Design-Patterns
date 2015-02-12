using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public interface IPCFactory
    {
        Box CreateBox();
        ConsoleApplication.Processor.Processor CreateProcessor();
        ConsoleApplication.MainBoard.MainBoard CreateMainBoard();
        ConsoleApplication.Hdd.Hdd CreateHdd();
        ConsoleApplication.Memory.Memory CreateMemory();
    }
}
