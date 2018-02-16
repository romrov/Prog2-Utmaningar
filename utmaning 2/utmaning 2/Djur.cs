using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utmaning_2
{
    class Djur
    {
        string namn, läte, djurTyp;

        public Djur(string namn, string läte, string djurTyp)
        {
            this.namn = namn;
            this.läte = läte;
            this.djurTyp = djurTyp;
        }

        public void Läte()
        {
            Console.WriteLine("Djuret säger: "+läte);
        }

        public void Heter()
        {
            Console.WriteLine("Djuret heter: "+namn);
        }

        public void DjurTyp()
        {
            Console.WriteLine("Djuret är en: "+djurTyp);
        }
    }
}
