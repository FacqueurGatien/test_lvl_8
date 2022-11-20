using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRedLine
{

    internal class Joueur
    {
        private string pseudo;
        private Color? couleur;
        public Joueur()
        {
            Pseudo = "";
            Couleur = null;
        }

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public Color? Couleur { get => couleur; set => couleur = value; }
    }
}
