namespace DuckSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You'll need this method for the second part of the Template Method Pattern
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);
        }


// You'll need this method for the second part of the Template Method Pattern
public static void Display(object[] objects)
{
foreach (object o in objects)
{
    Console.WriteLine(o.ToString());
}
Console.WriteLine("");
}
}
}
