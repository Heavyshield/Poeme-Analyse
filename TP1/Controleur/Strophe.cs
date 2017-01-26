using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TP1.Controleur;
using TP1.Modele;

namespace TP1
{

    /* Génere les vers d'une strophe*/
    class Strophe
    {
        private int stropheRank;
        private int stropheLength;
        private IList<Vers> versList;

        /* Constructeur */
        public Strophe(int length,int rank)
        {
            versList = new List<Vers>();
            stropheRank = rank;
            stropheLength = length;
            Console.WriteLine("Création de la strophe n°" + stropheRank);

            int i = 0;

            while (i < stropheLength)
            {
                    AddVer();
                Console.WriteLine("vers n°" + i);
               
                i ++;
            }

            Console.WriteLine("strophe n°" + (stropheRank+1) + "terminé");

        }

        /* rajouter un ver a versLists */
        private Vers AddVer()
        {
            string result;

            Console.WriteLine("Veuillez écrire un vers");

            result = Console.ReadLine();

            Vers ver = new Vers(result);
            versList.Add(ver);

            return ver;
        }

        /* Get verslist */
        public IList<Vers> VersList
        {
            get
            {
                return versList;
            }
        }
    }
}
