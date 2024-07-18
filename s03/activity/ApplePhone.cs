using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace activity
{
    internal class ApplePhone : MobileDevice, ICellphone
    {
        public bool IsWithTouchButton { get; set; }

        public ApplePhone(string model, int price, string supplier, bool isWithTouchButton) : base(model, price, supplier)
        {
            IsWithTouchButton = isWithTouchButton;
        }

        public override void SendText(string message, string recipient)
        {
            Console.WriteLine($"Result from Apple Phone: ");
            Console.WriteLine($"Text message sent to: { recipient} < 3 :D");
            Console.WriteLine("Where have you been?");
        }

        public override void PlayMusic(string songName)
        {
            Console.WriteLine($"Result from Apple Phone: ");
            Console.WriteLine($"The song { songName} is playing on Spotify.Smile for the camera");
        }

        public override void CaptureVideo()
        {
            base.CaptureVideo();
            Console.WriteLine("What's up with Al James?");
        }









    }
}
