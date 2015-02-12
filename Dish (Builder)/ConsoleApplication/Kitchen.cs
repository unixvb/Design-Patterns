using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Kitchen
    {
        public void Construct(Cook cook)
        {
            cook.AddDough();
            cook.AddMeat();
            cook.AddVegetables();
            cook.AddChees();
        }
    }
}
