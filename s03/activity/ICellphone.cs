using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal interface ICellphone
    {
        void SendText(string message, string recipient);
        void PlayMusic(string songName);



    }
}
