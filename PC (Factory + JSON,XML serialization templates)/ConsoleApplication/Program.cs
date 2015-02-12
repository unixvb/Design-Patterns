using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            PCConfigurator PcConfigurator = new PCConfigurator();
            PC Pc = new PC();
            HomePCFactory PcFactory = new HomePCFactory();
            //OfficePCFactory PcFactory = new OfficePCFactory();

            PcConfigurator.PCFactory = PcFactory;
            PcConfigurator.Configurate(Pc);

            Console.WriteLine(Pc.Box.color + " " + Pc.Hdd.producer + " " + Pc.MainBoard.producer + " " + Pc.Memory.type + " " + Pc.Processor.producer);
            Code code = new Code();
            ICode iCode = code.Serealize("XML");
            //ICode iCode = code.Serealize("JSON");
            Console.WriteLine("\n\n" + iCode.Serialize<PC>(Pc));
        }
    }
}
