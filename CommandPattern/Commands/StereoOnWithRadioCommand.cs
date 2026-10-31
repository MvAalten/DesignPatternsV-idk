using VendorClasses;

namespace CommandPattern.Commands
{
    internal class StereoOnWithRadioCommand : Command
    {
        Stereo stereo;

        public StereoOnWithRadioCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetRadio();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
