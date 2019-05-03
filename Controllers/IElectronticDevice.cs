namespace Controllers
{ /// <summary>
/// This is a interface that is going to controller the behavior of any device.
/// </summary>
    interface IElectronticDevice
    {
        void On();
        void Off();
        void VolumeUp(); 
        void VolumeDown();
    }
}