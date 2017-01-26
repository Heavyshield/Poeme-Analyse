using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.View;


namespace TP1.Controleur
{
    /* Génere les strophes d'un poème */
    class Poeme
    {
       private int stropheNumber;
       private int stropheLength;
       public Strophe[] stropheList;
       private string poemeName;

        /* Constructeur */
        public Poeme(string name,int stropheNum)
        {
            stropheNumber = stropheNum;
            poemeName = name;

            Affichage menu = new Affichage();
            stropheLength = menu.StropheLength();

            stropheList = new Strophe[stropheNumber];

            int i = 0;
            while ( i < stropheNumber)
            {
                Strophe strophe = new Strophe(stropheLength,i);
                stropheList[i] = strophe;
                i++;
            }

            Console.WriteLine("Poeme crée");

        }

        /* Get poemeName */
        public string PoemeName
        {
            get
            {
                return poemeName;
            }
        }

    }
}
