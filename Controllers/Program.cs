using System;

namespace Controllers
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronticDevice TVClicker= TVRemote.GetDevice();
            PowerButton thePowerButton = new PowerButton(TVClicker);
            VolumeUpButton theVolumeUpButton = new VolumeUpButton(TVClicker);
            Button theVolumeDownButton = new VolumeDownButton(TVClicker);

            thePowerButton.Execute();
            theVolumeUpButton.Execute();
            theVolumeDownButton.Execute();
            Console.ReadKey();

        }
    }
}
