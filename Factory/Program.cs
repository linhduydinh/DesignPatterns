using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();


            NYPizzaStore nYPizzaStore = new NYPizzaStore();
            nYPizzaStore.orderPizza(type);

        }


    }
}
