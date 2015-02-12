using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Code
    {
        ICode iCode { get; set; }
        public ICode Serealize(string str)
        {
            if (str == "JSON")
            {
                return new JSON_Code();
            }
            else if (str == "XML")
            {
                return new XML_Code();
            }
            return null;
        }
    }
}
