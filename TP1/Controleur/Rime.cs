using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP1.Controleur
{
    /* Parse rime (retire les //) */
    class Rime
    {
        private string rime;

        /* Constructeur */
        public Rime(string a)
        {
            rime = "" + a.Substring(1, a.Length - 1) + "";
            rime = a;

            Console.WriteLine("Rime créée");
        }

        /* Get rime */
        public string GetRime
        {
            get
            {
                return rime;
            }
        }
    }
}
