using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class CookAndriy : Cook
    {
        Product dish = new Product();

        public override void AddDough()
        {
            dish.Add("good dough");
        }
        public override void AddChees()
        {
            dish.Add("good chees");
        }
        public override void AddMeat()
        {
            dish.Add("good meat");
        }
        public override void AddVegetables()
        {
            dish.Add("good vegetables");
        }
        public override Product GetDish()
        {
            return dish;
        }
    }
}
