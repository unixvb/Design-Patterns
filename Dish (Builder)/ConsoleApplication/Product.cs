using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Product
    {
        List<string> Ingredients = new List<string>();

        public void Add(string ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void Show(string CookName)
        {
            string str = "Cook name: "+ CookName + "\n\nDish ingredients:\n\n";
            foreach (string T in Ingredients)
            {
                str += T + "\n";
            }
            str += "\n===================================\n";
            Console.WriteLine(str);
        }
    }
}
