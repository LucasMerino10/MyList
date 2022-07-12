using MongoDB.Bson;
using System;

namespace MyList.Modele
{
    public class Jeu : IComparable
    {
        // propriétés
        public ObjectId Id { get; set; }
        /// <summary>
        /// Désigne l'utilisateur qui crée l'entrée media
        /// </summary>
        public string utilisateur { get; set; }
        /// <summary>
        /// Titre du media
        /// </summary>
        public string titre { get; set; }
        /// <summary>
        /// Annee de sortie du media
        /// </summary>
        public int sortie { get; set; }
        /// <summary>
        /// Note attribué au media par l'utilisateur
        /// </summary>
        public int note { get; set; }
        /// <summary>
        /// Commentaire perso de l'utilisateur
        /// </summary>
        public string commentaire { get; set; }
        /// <summary>
        /// Plateforme sur laquelle le média à été visionnée/utilisé
        /// </summary>
        public string plateforme { get; set; }
        public int tempsJeu { get; set; }
        public string img { get; set; }
        public DateTime dateAjout { get; set; }

        public string developpeur { get; set; }

        public string genre { get; set; }


        public Jeu(string utilisateur, string titre, int sortie, int note, string commentaire, string plateforme, int tempsJeu, string img, DateTime dateAjout, string developpeur, string genre)
        {
            this.utilisateur = utilisateur;
            this.titre = titre;
            this.sortie = sortie;
            this.note = note;
            this.commentaire = commentaire;
            this.plateforme = plateforme;
            this.tempsJeu = tempsJeu;
            this.img = img;
            this.dateAjout = dateAjout;
            this.developpeur = developpeur;
            this.genre = genre;
        }

        public int CompareTo(object obj)
        {
            return dateAjout.CompareTo(((Serie)obj).dateAjout);
        }

        public string GetSortie()
        {
            return "Année de sortie : " + this.sortie;
        }

        public string GetCommentaire()
        {
            if (this.commentaire != "")
            {
                return "Commentaire : " + this.commentaire;
            }
            else
            {
                return "";
            }
        }

        public string GetDateAjout()
        {
            this.dateAjout = this.dateAjout.ToLocalTime();
            string jour = this.dateAjout.Day.ToString();
            string mois = this.dateAjout.Month.ToString();
            if (this.dateAjout.Day < 10)
            {
                jour = "0" + this.dateAjout.Day;
            }
            if (this.dateAjout.Month < 10)
            {
                mois = "0" + this.dateAjout.Month;
            }
            return "Ajouté le " + jour + "/" + mois + "/" + this.dateAjout.Year;
        }

        public string GetUtilisateur()
        {
            return "Ajouté par " + this.utilisateur;
        }

        public string GetTempsJeu()
        {
            if (this.tempsJeu != 0)
            {
                return "Temps de jeu (estimation) : " + this.tempsJeu + " h";
            }
            else
            {
                return "";
            }
        }

        public string GetDeveloppeur()
        {
            if(this.developpeur != "")
            {
                return "Développeur : " + this.developpeur;
            }
            else
            {
                return "";
            }
        }

        public string GetGenre()
        {
            if(this.genre != "")
            {
                return "Genre(s) : " + this.genre;
            }
            else
            {
                return "";
            }
        }
    }

}
