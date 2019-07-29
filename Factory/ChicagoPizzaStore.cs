using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                Console.WriteLine("ChicagoCheesePizza");
                pizza = new ChicagoCheesePizza();
            }
            else if (type.Equals("creek"))
            {
                Console.WriteLine("ChicagoCreekPizza");
                pizza = new ChicagoCreekPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                Console.WriteLine("ChicagoPepperoniPizza");
                pizza = new ChicagoPepperoniPizza();
            }

            return pizza;
        }
    }
}
