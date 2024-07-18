using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace activity
{
    internal class ApplePhone : MobileDevice
    {
        public bool IsWithTouchButton { get; set; }

        public ApplePhone(string model, int price, string supplier, bool isWithTouchButton) : base(model, price, supplier)
        {
            IsWithTouchButton = isWithTouchButton;
        }


        public void BrowseWeb()
        {
            Console.WriteLine("ApplePhone is browsing the web using Safari.");
        }

        public override void CaptureVideo()
        {
            base.CaptureVideo();
            Console.WriteLine("What's up with Al James?");
        }









    }
}
