using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utmaning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ödla ödla = new Ödla("Hugo", "Roman let's go bowling", "ödla");
            Fågel fågel = new Fågel("Roman", "fack", "fågel");
            Kanin kanin = new Kanin("Erik", "jag är b0g", "kanin");

            ödla.Heter();
            ödla.Läte();
            ödla.DjurTyp();
            fågel.Heter();
            fågel.Läte();
            fågel.DjurTyp();
            kanin.Heter();
            kanin.Läte();
            kanin.DjurTyp();

            Console.ReadLine();
        }
    }
}
