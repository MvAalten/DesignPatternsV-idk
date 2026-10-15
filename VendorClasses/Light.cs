namespace VendorClasses
{
    public class Light
    {
        private string location;
        public Light(string location) 
        {
            this.location = location;
        }
        public void On()
        {
            Console.WriteLine($"{location} Light is turned on");
        }

        public void Off()
        {
            Console.WriteLine($"{location} Light is turned off");

        }
    }
}
