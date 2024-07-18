using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal class SamsungTab : MobileDevice
    {
        public bool Is5G { get; set; }

        public SamsungTab(string model, int price, string supplier, bool is5G) : base(model, price, supplier)
        {
            Is5G = is5G;
        }

        public void ApplyMonochromeFilter()
        {
            Console.WriteLine("Applying monochrome filter to your photo.");
        }

        public void BrowseWeb()
        {
            Console.WriteLine("SamsungTab is browsing the web using Chrome.");
        }

        public override void CaptureVideo()
        {
            base.CaptureVideo();
            Console.WriteLine("Showing the latest Hollywood updates.");
        }








    }
}
