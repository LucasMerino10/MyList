using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Modele
{
    class Jeu : Media
    {
        public Jeu(string utilisateur, string titre, int anneeSortie, int note, string commentaire, DateTime dateAjout, string plateforme)
            : base(utilisateur, titre, anneeSortie, note, commentaire, dateAjout, plateforme)
        {
        }
    }
}
