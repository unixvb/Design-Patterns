using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    public class JSON_Code : ICode
    {
        public string Serialize<T>(T jsonObject)
        {
            return JsonConvert.SerializeObject(jsonObject);
        }
    }
}
