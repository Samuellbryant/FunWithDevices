namespace Controllers
{ /// <summary>
/// This a TV remote whick gets all the Functionally of a TV remote would have. 
/// </summary>
    class TVRemote
    {
        public static IElectronticDevice GetDevice() {
            return new Television();
        } 
    }
}
