using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.View
{
    /* Affiche des messages en console et effectue du contrôle d'input */
    class Affichage
    {
        public bool isInitialized;

        /* Constructeur, isInitialized pour faire des tests */
        public  Affichage()
        {
            isInitialized = true;
        }

        public void Welcome()
        {
            Console.WriteLine("Bienvenue sur l'analyseur rimique");
        }

        public string ReadOrWrite()
        {
            Console.WriteLine("Souhaitez vous lire ou ecrire un poème ? tapper 'read' pour lire et 'write' pour écrire");
            string result = Console.ReadLine();

            if (result != "read" && result != "write")
            {
                ReadOrWrite();
            }
 
            return result;
        }

        public void Read()
        {
            Console.WriteLine("Listes des poemes...");

        }
        public int Write()
        {
            Console.WriteLine("Choisissez le nombre de strophes");
            int result = Convert.ToInt32(Console.ReadLine());

            if (result < 1 || result > 20)
            {
                Console.WriteLine("Erreur dans le format");
                Write();
            }
            return result;
        }

        internal int ChoosePoeme()
        {
            Console.WriteLine("Choisissez un poeme par son numéro, 1 par exemple");
            int result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Poeme n°" + result + " choisi");
            return result;
        }

        public string ReadOrAnalyse()
        {
            Console.WriteLine("read pour lire le poeme, analyse pour obtenir le schema ritmique");
            string result = Console.ReadLine();

            return result;
        }

        public string PoemeName()
        {
            Console.WriteLine("Choisissez le nom du poeme");
            string name = Console.ReadLine();
            return name;
        }

        public int StropheLength()
        {
            Console.WriteLine("Choissez le nombre de ligne par strophe de 1 à 14");
           int result = Convert.ToInt32(Console.ReadLine());
            if (result < 1 || result >14)
            {
                Console.WriteLine("La taille d'une strophe est entre 1 et 14 vers");
                StropheLength();
            }
            return result;
        }

    }
}
