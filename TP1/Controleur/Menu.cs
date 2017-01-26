using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Modele;
using TP1.View;

namespace TP1.Controleur
{
    /* Controleur */
    class Menu
    {
       private static Menu instance;
       public Menu()
        {
 
            Affichage affichage = new Affichage();
            affichage.Welcome();

            /* Choix lecture ou écriture */
            string option = affichage.ReadOrWrite();

            /* Affichage des poèmes */
            if ( option == "read")
            {
                affichage.Read();
                Content content = Content.Instance;
                IList<Poeme> poemeList = content.PoemeList;

                int a = poemeList.Count;
                if (a < 1)
                {
                    Console.WriteLine("Il n'y a pas de poèmes enregistrés");
                    Menu menus = new Menu();

                }

                int i = 0;

                foreach(Poeme poeme in poemeList)
                {
                    string name = poeme.PoemeName;
                    Console.WriteLine("["+i+"] "+name);
                    i++;
                }

                /* Lecture d'un poeme */
                int poemeRank = affichage.ChoosePoeme();
                 option = affichage.ReadOrAnalyse();

                if (option == "read")
                {
                    Poeme poeme = poemeList[poemeRank];
                    foreach(Strophe strophe in poeme.stropheList)
                    {
                        foreach(Vers ver in strophe.VersList)
                        {
                            string verString = ver.Content;
                            Console.WriteLine(verString);
                        }
                    }
                }

                /* Affichage du schéma rimique*/
                else if (option == "analyse")
                {
                    Poeme poeme = poemeList[poemeRank];
                    int b = 1;
                    foreach(Strophe strophe in poeme.stropheList)
                    {
                        SchemaRimique schemaRimique = new SchemaRimique();
                        string result = schemaRimique.getRimique(strophe);
                        Console.WriteLine("Le schema rimique de la strophe n°" + b);
                        Console.WriteLine(result);
                        b++;
                    }

                }

                /* Retour */
                Menu menu = new Menu();
            }

            /* Ecriture */
            else if ( option == "write")
            {
   
                Poeme poeme = new Poeme(affichage.PoemeName(),affichage.Write());
                Content content = Content.Instance;
                content.addPoeme(poeme);
                Console.WriteLine("Poème enregistré");

                /* Retour */
                Menu menu = new Menu();
            }
        }

        /* Singleton */
        public static Menu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Menu();
                }
                return instance;
            }
        }

        
    }
}
