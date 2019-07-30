using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        public string name;
        public Dough dough;
        public Sauce sauce;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clams;
        public List<Veggies> veggies;
        public List<string> toppings = new List<string>();
        public Pizza()
        {
            name = "";
            dough = new Dough();
            sauce = new Sauce();
            cheese = new Cheese();
            pepperoni = new Pepperoni();
            clams = new Clams();
            veggies = new List<Veggies>();
        }

        public abstract void prepare();

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

        public void setName(string name)
        {
            this.name = name;
        }

    }
}