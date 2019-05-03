namespace Controllers
{/// <summary>
/// The PowerButton  turns  the power of a device on  or off.  
/// </summary>
    class PowerButton:Button
    {
        private bool IsOn;
        
        public PowerButton(IElectronticDevice device):base(device)
        {
            IsOn = false;
        }
         public override void Execute()
        {
            if (!IsOn)
            {
                device.On();

            }
            else
            {
                device.Off();
            }
            IsOn =!IsOn;
        }
    }
}