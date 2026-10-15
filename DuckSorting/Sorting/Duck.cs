namespace DuckSorting
{
    internal class Duck
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"{name} weights {weight}";
        }
    }
}
