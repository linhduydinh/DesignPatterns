using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        public string name, dough, sauce;
        public List<string> toppings = new List<string>();
        public Pizza()
        {
            name = "";
            dough = "";
            sauce = "";
        }

        public void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Add dough" + dough);
            Console.WriteLine("Add sauce " + sauce);
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(" " + toppings[i]);
            }
        }

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in offical PizzaStore box");
        }

        public String getName()
        {
            return name;
        }

    }
}