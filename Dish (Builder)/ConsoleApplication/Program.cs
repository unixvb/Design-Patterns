using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            Cook Andriy = new CookAndriy();
            Cook Oleg = new CookOleg();
            Product product;

            kitchen.Construct(Andriy);
            product = Andriy.GetDish();
            product.Show("Andriy");

            kitchen.Construct(Oleg);
            product = Oleg.GetDish();
            product.Show("Oleg");
        }
    }
}
