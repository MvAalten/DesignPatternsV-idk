namespace TemplateMethodPattern
{
    public class HotChocolate : Beverage
    {
        public override void Brew()
        {
            Console.WriteLine("Mixing cocoa powder into hot milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding cream");
        }
    }
}
