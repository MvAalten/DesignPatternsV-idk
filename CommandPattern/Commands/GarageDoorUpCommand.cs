using VendorClasses;

namespace CommandPattern.Commands
{
    internal class GarageDoorUpCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Up();
        }

        public void Undo()
        {
            garageDoor.Down();
        }
    }
}
