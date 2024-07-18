namespace activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Invoke MobileDevice directly
            MobileDevice genericDevice = new MobileDevice("Mobile Device", 500, "Supplier");
            genericDevice.SendText("Spam message", "recipient");
            genericDevice.PlayMusic("any random song");
            genericDevice.CaptureVideo();

            Console.WriteLine();

            // Instantiate SamsungTab
            SamsungTab mySamsungTab = new SamsungTab("Galaxy Tab S7", 649, "Samsung", true);
            mySamsungTab.SendText("I'll call you back asap.", "Skusta Clee");
            mySamsungTab.PlayMusic("Skusta Clee - Noche Buena");
            mySamsungTab.CaptureVideo();
            mySamsungTab.ApplyMonochromeFilter();
            mySamsungTab.BrowseWeb();
            Console.WriteLine("Showing the latest Hollywood updates.");

            Console.WriteLine();

            // Instantiate ApplePhone
            ApplePhone myApplePhone = new ApplePhone("iPhone 12", 1099, "Apple Inc.", true);
            myApplePhone.SendText("How are you doing today?", "Hev Abi");
            myApplePhone.PlayMusic("CLR - K&B");
            myApplePhone.CaptureVideo();
            myApplePhone.BrowseWeb();
















        }
    }
}
