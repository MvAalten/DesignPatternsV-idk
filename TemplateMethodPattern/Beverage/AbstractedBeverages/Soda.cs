namespace TemplateMethodPattern
{
    public class Soda : Beverage
    {
        public override void Brew()
        {
            Console.WriteLine("Carbonating the soda");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon and Ice cubes");
        }
    }
}
