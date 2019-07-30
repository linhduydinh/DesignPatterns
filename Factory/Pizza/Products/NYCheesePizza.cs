namespace Factory
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            //dough = "Thin Crust Dough";
            //sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }

        public override void prepare()
        {
            //Console.WriteLine("Preparing " + name);
            //Console.WriteLine("Add dough" + dough);
            //Console.WriteLine("Add sauce " + sauce);
            //for (int i = 0; i < toppings.Count; i++)
            //{
            //    Console.WriteLine(" " + toppings[i]);
            //}
        }
    }
}