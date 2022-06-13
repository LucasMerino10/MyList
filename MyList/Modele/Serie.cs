using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Modele
{
    class Serie : Media
    {
        /// <summary>
        /// Précise la saison
        /// </summary>
        private int saison;

        public Serie(int saison, string utilisateur, string titre, int anneeSortie, int note, string commentaire, DateTime dateAjout, string plateforme)
            : base(utilisateur, titre, anneeSortie, note, commentaire, dateAjout, plateforme)
        {
            this.saison = saison;
        }
    }
}
