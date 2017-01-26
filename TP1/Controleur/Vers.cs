using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TP1.Controleur;

namespace TP1
{
    /* Génere la rime d'un ver */
    class Vers
    {
        private Rime rime;
        private string content;
        public Vers(string b)
        {
            rime = getRime();
            content = b;
            Console.WriteLine("Vers crée");
        }

        /* Get la rime depuis la console, contrôle le format */
        private Rime getRime()
        {
            Regex myRegex = new Regex("/./");
            Console.WriteLine("Indiquez la rime sous le format /a/");
            string rime = Console.ReadLine();

            bool boolResult = myRegex.IsMatch(rime);
            while (boolResult == false)
            {
                Console.WriteLine("format non reconnus");
                Console.WriteLine("Indiquez la rime sous le format /a/");
                rime = Console.ReadLine();
                boolResult = myRegex.IsMatch(rime);
            }

            Rime rimeObject = new Rime(rime);

            return rimeObject;
        }

        /* Get rime */
        public Rime Rime
        {
            get
            {
                return rime;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }
        }
    }
}
