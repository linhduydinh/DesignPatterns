using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                Console.WriteLine("NYCheesePizza");
                pizza = new NYCheesePizza();
            }
            else if (type.Equals("creek"))
            {
                Console.WriteLine("NYCreekPizza");
                pizza = new NYCreekPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                Console.WriteLine("NYPepperoniPizza");
                pizza = new NYPepperoniPizza();
            }

            return pizza;
        }
    }
}
