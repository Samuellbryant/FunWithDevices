using System;


namespace Controllers
{ /// <summary>
/// Class Televison is a object that is implemeted from IElectronticDevice and  it is using  On, Off, VolumeOn, VolumeOff methods to turn the Television on or off  or turn  the volume up or down. This also checks if the tevision is muted  or maxed   
/// </summary>
    class Television : IElectronticDevice
    {
        public bool IsOn { get; private set; } = false;
        public int Volume { get; private set; } = 10;
        const int minVolume = 0;
        const int maxVolume = 100;
        public void Off()
        {
            Console.WriteLine("The television is turn off.");
            IsOn = false;
        }

        public void On()
        {
            Console.WriteLine("The television is turned on.");
            IsOn = true;
        }

        public void VolumeDown()
        {
            if (IsOn)
            {
                --Volume;
                if (IsMuted())
                {
                    Console.WriteLine("The television is muted");
                    Volume = minVolume;
                }
                else
                { Console.WriteLine("The volume went down to {0}", Volume); }
            }
            else { Console.WriteLine("The television is off"); }
    }


        public void VolumeUp()
        {
            if (IsOn)
            {
                ++Volume;
                if (IsMaxed())
                {
                    Console.WriteLine("VOLUME IS MAXED!!");
                    Volume = maxVolume;
                }
                else Console.WriteLine("The volume went up to {0}", Volume);
            }
            else { Console.WriteLine("The television is off."); }

        }
        private bool IsMuted()
        { return Volume <= minVolume ? true : false; }
        private bool IsMaxed()
        { return Volume >= maxVolume ? true : false; }
    }
}
