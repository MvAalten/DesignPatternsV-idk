using VendorClasses;

namespace CommandPattern.Commands
{
    internal class StereoOnWithDvdCommand : Command
    {
        Stereo stereo;

        public StereoOnWithDvdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetDVD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
