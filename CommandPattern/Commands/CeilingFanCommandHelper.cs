using VendorClasses;

namespace CommandPattern.Commands
{
    internal static class CeilingFanCommandHelper
    {
        public static void RestoreSpeed(CeilingFan ceilingFan, int prevSpeed)
        {
            if (prevSpeed == ceilingFan.HIGH)
                ceilingFan.High();
            else if (prevSpeed == ceilingFan.MEDIUM)
                ceilingFan.Medium();
            else if (prevSpeed == ceilingFan.LOW)
                ceilingFan.Low();
            else
                ceilingFan.Off();
        }
    }
}
