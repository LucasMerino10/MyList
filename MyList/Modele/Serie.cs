using MongoDB.Bson;
using System;

namespace MyList.Modele
{
    public class Serie : IComparable
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
        /// Précise la saison
        /// </summary>
        public int saison { get; set; }
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
        public DateTime dateAjout { get; set; }
        public string img { get; set; }

        public string casting { get; set; }

        public string genre { get; set; }


        public Serie(string utilisateur, string titre, int sortie, int saison, int note, string commentaire, string plateforme, DateTime dateAjout, string img, string casting, string genre)
        {
            this.utilisateur = utilisateur;
            this.titre = titre;
            this.sortie = sortie;
            this.saison = saison;
            this.note = note;
            this.commentaire = commentaire;
            this.plateforme = plateforme;
            this.img = img;
            this.dateAjout = dateAjout;
            this.casting = casting;
            this.genre = genre;
        }

        public int CompareTo(object obj)
        {
            return this.dateAjout.CompareTo(((Serie)obj).dateAjout);
        }

        public string GetSaison()
        {
            return "Saison " + this.saison;
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

        public string GetCasting()
        {
            if(this.casting != "")
            {
                return "Casting : " + this.casting;
            }
            else
            {
                return "";
            }
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
    }
}
