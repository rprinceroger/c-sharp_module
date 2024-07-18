using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal class SamsungTab : MobileDevice, ICellphone
    {
        public bool Is5G { get; set; }

        public SamsungTab(string model, int price, string supplier, bool is5G) : base(model, price, supplier)
        {
            Is5G = is5G;
        }

        public override void SendText(string message, string recipient)
        {
            Console.WriteLine($"Result from Samsung Tablet: ");
            Console.WriteLine($"Text message sent to: {recipient} <3 :D");
            Console.WriteLine("I'll call you back asap.");
        }

        public override void PlayMusic(string songName)
        {
            Console.WriteLine($"Result from Samsung Tablet: ");
            Console.WriteLine($"The song { songName} is playing on Spotify.Smile for the camera");
        }

        public void ApplyMonochromeFilter()
        {
            Console.WriteLine("Applying monochrome filter to your photo.");
        }

        public override void CaptureVideo()
        {
            base.CaptureVideo();
            Console.WriteLine("Showing the latest Hollywood updates.");
        }








    }
}
