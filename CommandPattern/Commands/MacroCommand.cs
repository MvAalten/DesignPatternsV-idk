using VendorClasses;

namespace CommandPattern.Commands
{
    internal class MacroCommand : Command
    {
        Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (Command c in commands)
            {
                c.Execute();
            }
        }

        public void Undo()
        {
            foreach (Command c in commands)
            {
                c.Undo();
            }
        }
    }
}
