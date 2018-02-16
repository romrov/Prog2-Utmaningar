using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utmaning_3
{
    class Radio : MinaSaker, IElektronik
    {
        public Radio(int Värde, int Vikt, string Sak, string Funktion) : base(Värde, Vikt, Sak, Funktion)
        {
        }

        public void Off()
        {
            Console.WriteLine("Radion stängs av");
        }

        public void On()
        {
            Console.WriteLine("Radion låter illa");
        }
    }
}
