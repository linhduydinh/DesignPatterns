using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class PizzaStore
    {

        public Pizza orderPizza(String type)
        {
            Pizza pizza = null;
            createPizza(type);

            //pizza.prepare();
            //pizza.bake();
            //pizza.cut();
            //pizza.box();

            return pizza;
        }

        public abstract Pizza createPizza(String type);
    }
}
