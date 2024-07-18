using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace activity
{
    internal class MobileDevice
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public string Supplier { get; set; }

        public MobileDevice(string model, int price, string supplier)
        {
            Model = model;
            Price = price;
            Supplier = supplier;
        }

        public virtual void SendText(string message, string recipient)
        {
            Console.WriteLine("Result from Mobile Device:");
            Console.WriteLine($"Text message sent to: {recipient} <3 :D");
            Console.WriteLine(message);
        }

        public virtual void PlayMusic(string songName)
        {
            Console.WriteLine("Result from Mobile Device:");
            Console.WriteLine($"The song {songName} is playing on Spotify. Smile for the camera");
        }

        public virtual void CaptureVideo()
        {
            Console.WriteLine("Result from Mobile Device:");
            Console.WriteLine("Capturing video of your best moments.");
        }







    }
}
