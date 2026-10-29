namespace DuckSorting
{
    internal class Duck : IComparable
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(object? obj)
        {
            Duck otherDuck = (Duck)obj!;
            return weight - otherDuck.weight;
        }

        public override string ToString()
        {
            return $"{name} weights {weight}";
        }
    }
}
