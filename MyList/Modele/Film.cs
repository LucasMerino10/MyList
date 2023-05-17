using MongoDB.Bson;
using System;

namespace MyList.Modele
{
    public class Film : IComparable
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
        /// Durée du film en minute
        /// </summary>
        public int duree { get; set; }
        /// <summary>
        /// Annee de sortie du media
        /// </summary>
        public int sortie { get; set; }
        /// <summary>
        /// Précise les acteurs principaux
        /// </summary>
        public string casting { get; set; }
        /// <summary>
        /// Note attribué au media par l'utilisateur
        /// </summary>
        public double note { get; set; }
        /// <summary>
        /// Commentaire perso de l'utilisateur
        /// </summary>
        public string commentaire { get; set; }
        /// <summary>
        /// Plateforme sur laquelle le média à été visionnée/utilisé
        /// </summary>
        public string plateforme { get; set; }
        public string img { get; set; }
        public DateTime dateAjout { get; set; }

        public string realisateur { get; set; }

        public string genre { get; set; }

        public string imdb { get; set; }


        public Film(string utilisateur, string titre, int duree, int sortie, string casting, double note, string commentaire, string plateforme, string img, DateTime dateAjout, string realisateur, string genre, string imdb)
        {
            this.utilisateur = utilisateur;
            this.titre = titre;
            this.duree = duree;
            this.sortie = sortie;
            this.casting = casting;
            this.note = note;
            this.commentaire = commentaire;
            this.plateforme = plateforme;
            this.img = img;
            this.dateAjout = dateAjout;
            this.realisateur = realisateur;
            this.genre = genre;
            this.imdb = imdb;
        }

        public int CompareTo(object obj)
        {
            return this.dateAjout.CompareTo(((Serie)obj).dateAjout);
        }

        public string GetCasting()
        {
            if (this.casting != "")
            {
                return "Casting : " + this.casting;
            }
            else
            {
                return "";
            }
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
            return "Ajouté par " + GetUtilisateur() + " le " + jour + "/" + mois + "/" + this.dateAjout.Year;
        }

        public string GetDate()
        {
            return this.dateAjout.Year.ToString();
        }

        public string GetUtilisateur()
        {
            return this.utilisateur;
        }

        public string GetDuree()
        {
            return "Durée : " + this.duree / 60 + "h " + this.duree % 60 + "min";
        }

        public string GetGenre()
        {
            if (this.genre != "")
            {
                return "Genre(s) : " + this.genre;
            }
            else
            {
                return "";
            }
        }

        public string GetRealisateur()
        {
            return "Réalisateur : " + this.realisateur;
        }

        public string GetImdb()
        {
            return this.imdb;
        }
    }
}
