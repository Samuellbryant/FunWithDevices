namespace Controllers
{
    abstract class Button : ICommand
    {
        protected IElectronticDevice device;
        public Button(IElectronticDevice device) {
            this.device = device;
        }
        public abstract void Execute();
    }
}
