using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Modele
{
    class Film : Media
    {
        /// <summary>
        /// Casting du film
        /// </summary>
        private string casting;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="casting"></param>
        /// <param name="utilisateur"></param>
        /// <param name="titre"></param>
        /// <param name="anneeSortie"></param>
        /// <param name="note"></param>
        /// <param name="commentaire"></param>
        /// <param name="dateAjout"></param>
        public Film(string casting, string utilisateur, string titre, int anneeSortie, int note, string commentaire, DateTime dateAjout, string plateforme) 
            : base(utilisateur, titre, anneeSortie, note, commentaire, dateAjout, plateforme)
        {
            this.casting = casting;
        }
    }
}
