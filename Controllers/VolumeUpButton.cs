namespace Controllers
{ /// <summary>
/// The VolumeUpButton calls VolumeUp method for any IElectronicDevice device.
/// </summary>
    class VolumeUpButton : Button
    {
        public VolumeUpButton(IElectronticDevice device) : base(device){ }
        public override void Execute() => device.VolumeUp();
    }
}
