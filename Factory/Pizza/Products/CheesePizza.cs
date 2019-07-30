namespace Factory
{
    internal class CheesePizza : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void prepare()
        {
            System.Console.WriteLine("Preparing " + name);
            dough = pizzaIngredientFactory.createDough();
            sauce = pizzaIngredientFactory.createSauce();
            cheese = pizzaIngredientFactory.createCheese();
        }
    }
}