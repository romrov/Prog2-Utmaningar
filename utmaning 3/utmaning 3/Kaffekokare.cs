using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utmaning_3
{
    class Kaffekokare : MinaSaker, IElektronik
    {
        public Kaffekokare(int Värde, int Vikt, string Sak, string Funktion) : base(Värde, Vikt, Sak, Funktion)
        {
        }

        public void Off()
        {
            Console.WriteLine("Kaffekokaren stängs av");
        }

        public void On()
        {
            Console.WriteLine("Kaffekokaren kokar kaffe");
        }
    }
}
