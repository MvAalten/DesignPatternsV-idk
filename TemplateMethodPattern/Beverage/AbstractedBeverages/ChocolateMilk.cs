namespace TemplateMethodPattern
{
    public class ChocolateMilk : Beverage
    {
        public override void Brew()
        {
            Console.WriteLine("Mixing cocoa powder into cold milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding whipped cream");
        }
    }
}
