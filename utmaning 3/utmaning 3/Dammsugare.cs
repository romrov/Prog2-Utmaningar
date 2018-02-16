using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utmaning_3
{
    class Dammsugare : MinaSaker, IElektronik
    {
        public Dammsugare(int Värde, int Vikt, string Sak, string Funktion) : base(Värde, Vikt, Sak, Funktion)
        {
        }

        public void Off()
        {
            Console.WriteLine("Dammsugaren stängs av");
        }

        public void On()
        {
            Console.WriteLine("Dammsugaren suger");
        }
    }
}
