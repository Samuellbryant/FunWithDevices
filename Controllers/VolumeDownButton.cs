

namespace Controllers
{/// <summary>
/// The VolumeDownButton calls VolumeDown method for any IElectronicDevice device.
/// </summary>
    class VolumeDownButton : Button
    {
        public VolumeDownButton(IElectronticDevice device) : base(device) { }
        public override void Execute() => device.VolumeDown();

    }
}
