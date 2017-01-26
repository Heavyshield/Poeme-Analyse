using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Controleur
{
    /* Get les rimes dans les vers et les retournes en string */
    class SchemaRimique
    {
        private string a;
        private string b;
        private string c;
        private string d;

        public string getRimique(Strophe strophe)
        {

            IList<Vers> versList = strophe.VersList;
            List<string> rimeList = new List<string>();


            foreach (Vers ver in versList)
            {
                string rime = ver.Rime.GetRime;
                rimeList.Add(rime);
            }

            string rimique = null;

            /* Compare element (une rime) avec a,b,d,c correspondant a un schéma*/
            /* Concatène la chaîne */

            foreach (string element in rimeList)
            {
                if (element == a || a == null)
                {
                    a = element;
                    rimique += "A";
                }
                else if (element == b || b ==null)
                {
                    b = element;
                    rimique += "B";
                }
                else if (element == c || c == null)
                {
                    c = element;
                    rimique += "C";
                }
                else if (element == d || d == null)
                {
                    d = element;
                    rimique += "D";
                }

            }
            return rimique;
        }
    }
}
