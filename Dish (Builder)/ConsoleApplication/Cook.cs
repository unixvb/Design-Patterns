using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    abstract class Cook
    {
        public abstract void AddDough();
        public abstract void AddChees();
        public abstract void AddMeat();
        public abstract void AddVegetables();
        public abstract Product GetDish();
    }
}
