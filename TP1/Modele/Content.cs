using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Controleur;

namespace TP1.Modele
{
    /* instance contenant la liste des poèmes */
    class Content
    {

        private static Content instance;
        private IList<Poeme> poemeList;

        /* Constructeur */
        private Content()
        {
             poemeList = new List<Poeme>();
        }

        /* Singleton */
        public static Content Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Content();
                }
                return instance;
            }
        }

        /*ajoute un poème a poemeList */
        public void addPoeme(Poeme poeme)
        {
            poemeList.Add(poeme);
        }

        public void deletePoeme()
        {

        }

        /* Get poemeList */
        public IList<Poeme> PoemeList
        {
            get
            {
                return poemeList;
            }
        }


    }
}


