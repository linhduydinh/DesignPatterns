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
            string nyType = Console.ReadLine();
            //string chicagoType = Console.ReadLine();


            NYPizzaStore nYPizzaStore = new NYPizzaStore();
            ChicagoPizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            var pizza = nYPizzaStore.orderPizza(nyType);
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            //pizza =  chicagoPizzaStore.orderPizza(chicagoType);
            //Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

        }


    }
}
