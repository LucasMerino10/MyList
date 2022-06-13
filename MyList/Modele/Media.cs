using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Modele
{
    class Media
    {
        /// <summary>
        /// Désigne l'utilisateur qui crée l'entrée media
        /// </summary>
        private string utilisateur;
        /// <summary>
        /// Titre du media
        /// </summary>
        private string titre;
        /// <summary>
        /// Annee de sortie du media
        /// </summary>
        private int anneeSortie;
        /// <summary>
        /// Note attribué au media par l'utilisateur
        /// </summary>
        private int note;
        /// <summary>
        /// Commentaire perso de l'utilisateur
        /// </summary>
        private string commentaire;
        /// <summary>
        /// Date d'ajout du media dans la BDD
        /// </summary>
        private DateTime dateAjout;
        /// <summary>
        /// Plateforme sur laquel la série à été visionnée
        /// </summary>
        private string plateforme;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="titre"></param>
        /// <param name="anneeSortie"></param>
        /// <param name="note"></param>
        /// <param name="commentaire"></param>
        /// <param name="dateAjout"></param>
        public Media(string utilisateur, string titre, int anneeSortie, int note, string commentaire, DateTime dateAjout, string plateforme)
        {
            this.utilisateur = utilisateur;
            this.titre = titre;
            this.anneeSortie = anneeSortie;
            this.note = note;
            this.commentaire = commentaire;
            this.dateAjout = dateAjout;
        }

    }
}
