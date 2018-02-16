using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utmaning_3
{
    class MinaSaker
    {
        int vikt, värde;
        string sak, funktion;

        public MinaSaker(int Värde, int Vikt, string Sak, string Funktion)
        {
            värde = Värde;
            vikt = Vikt;
            sak = Sak;
            funktion = Funktion;
        }

        public void Information()
        {
            Console.WriteLine("Detta är en "+sak);
            if (this is IElektronik)
            {
                Console.WriteLine("Detta föremål är elektroniskt");
            }
            Console.WriteLine("Vikt: "+vikt+"kg");
            Console.WriteLine("Värde: "+värde+"kronor");
            Console.WriteLine("Detta föremål kan: "+funktion);
        }
    }
}
