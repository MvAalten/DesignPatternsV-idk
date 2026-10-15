namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example with simple classes
            Console.WriteLine("\n\nExample with simple classes\n\n");
            SimpleTea simpleTea = new SimpleTea();
            SimpleCoffee simpleCoffee = new SimpleCoffee();

            simpleTea.prepareRecipe();
            simpleCoffee.PrepareRecipe();


            // Example with abstracted classes
            Console.WriteLine("\n\nNow with abstracted classes\n\n");

            Beverage tea = new Tea();
            Beverage coffee = new Coffee();

            // TODO: Create a Chocolatemilk child class of Beverage
            // TODO: Instantiate a Chocolatemilk object
            // TODO: Prepare the Chocolatemilk object

            tea.PrepareRecipe();
            coffee.PrepareRecipe();

            // Example with hooked abstracted classes
            Console.WriteLine("\n\n Now with hooked classes\n\n");

            // TODO: Instantiate a CoffeeWithHook and a TeaWithHook
            // TODO: Call PrepareRecipe method of both instances
        }
    }
}