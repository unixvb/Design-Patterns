using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class CookOleg : Cook
    {
        Product dish = new Product();

        public override void AddDough()
        {
            dish.Add("bad dough");
        }
        public override void AddChees()
        {
            dish.Add("bad chees");
        }
        public override void AddMeat()
        {
            dish.Add("bad meat");
        }
        public override void AddVegetables()
        {
            dish.Add("bad vegetables");
        }
        public override Product GetDish()
        {
            return dish;
        }
    }
}
