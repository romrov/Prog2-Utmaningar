using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utmaning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MinaSaker> saker = new List<MinaSaker>();

            Kaffekokare kaffekokare = new Kaffekokare(150, 2, "Kaffekokare", "Koka kaffe");
            Dammsugare dammsugare = new Dammsugare(450, 5, "Dammsugare", "suga damm");
            Bord bord = new Bord(700, 8, "Bord", "Ha föremål på sig");
            Radio radio = new Radio(300, 1, "Radio", "Ta emot radiosignaler");

            saker.Add(kaffekokare);
            saker.Add(dammsugare);
            saker.Add(bord);
            saker.Add(radio);

            foreach (MinaSaker sak in saker)
            {
                sak.Information();
            }

            Console.ReadLine();
        }
    }
}
