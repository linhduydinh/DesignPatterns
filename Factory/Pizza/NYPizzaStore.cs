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
            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.setName("NY Style Cheese Pizza");
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
