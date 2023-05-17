using MongoDB.Driver;
using MyList.Connexion;
using MyList.Modele;
using MyList.Vue;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MyList.Controleur
{
    public class Controle
    {
        private readonly string imageDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/Images/";
        private readonly string localImageDirectory = @"C:\MyList\";
        ToolTip t1 = new ToolTip();
        /// <summary>
        /// chaîne de connexion à la bdd
        /// </summary>
        readonly string stringconnect = "mongodb+srv://user_mylist:bJMABBnaEP5ULnnZ@cluster0.lk3yn.mongodb.net/MyList?retryWrites=true&w=majority";
        /// <summary>
        /// Objet ConnexionBDD
        /// </summary>
        private readonly ConnexionBDD connexionBDD;
        private readonly string database = "MyList";

        public Controle()
        {
            this.connexionBDD = ConnexionBDD.GetInstance(stringconnect, database);
            FrmList frmList = new FrmList(this);
            frmList.ShowDialog();
        }

        /// <summary>
        /// Récupère le contenu de la collection Films
        /// </summary>
        /// <returns></returns>
        public List<Film> GetFilms(string utilisateur, string annee, string titre)
        {
            return connexionBDD.CollectionToList<Film>("Films", utilisateur, annee, titre);
        }

        /// <summary>
        /// Récupère le contenu de la collection Séries
        /// </summary>
        /// <returns></returns>
        public List<Serie> GetSeries(string utilisateur, string annee, string titre)
        {
            return connexionBDD.CollectionToList<Serie>("Séries", utilisateur, annee, titre);
        }

        /// <summary>
        /// Récupère le contenu de la collection Jeux
        /// </summary>
        /// <returns></returns>
        public List<Jeu> GetJeux(string utilisateur, string annee, string titre)
        {
            return connexionBDD.CollectionToList<Jeu>("Jeux", utilisateur, annee, titre);
        }

        /// <summary>
        /// Ajoute une série dans la BDD
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="titre"></param>
        /// <param name="sortie"></param>
        /// <param name="saison"></param>
        /// <param name="note"></param>
        /// <param name="commentaire"></param>
        /// <param name="plateforme"></param>
        /// <param name="dateAjout"></param>
        /// <param name="img"></param>
        public void AjoutSerie(string utilisateur, string titre, int sortie, int saison, double note, string commentaire, string plateforme, DateTime dateAjout, string img, string casting, string genre, string imdb)
        {
            Serie serie = new Serie(utilisateur, titre, sortie, saison, note, commentaire, plateforme, dateAjout, img, casting, genre, imdb);
            connexionBDD.Ajout<Serie>("Séries", serie);
        }

        /// <summary>
        /// Ajoute un film dans la BDD
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="titre"></param>
        /// <param name="duree"></param>
        /// <param name="sortie"></param>
        /// <param name="casting"></param>
        /// <param name="note"></param>
        /// <param name="commentaire"></param>
        /// <param name="plateforme"></param>
        /// <param name="img"></param>
        /// <param name="dateAjout"></param>
        public void AjoutFilm(string utilisateur, string titre, int duree, int sortie, string casting, double note, string commentaire, string plateforme, string img, DateTime dateAjout, string realisateur, string genre, string imdb)
        {
            Film film = new Film(utilisateur, titre, duree, sortie, casting, note, commentaire, plateforme, img, dateAjout, realisateur, genre, imdb);
            connexionBDD.Ajout<Film>("Films", film);
        }

        /// <summary>
        /// Ajoute un jeu dans la BDD
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="titre"></param>
        /// <param name="sortie"></param>
        /// <param name="note"></param>
        /// <param name="commentaire"></param>
        /// <param name="plateforme"></param>
        /// <param name="tempsJeu"></param>
        /// <param name="img"></param>
        /// <param name="dateAjout"></param>
        public void AjoutJeu(string utilisateur, string titre, int sortie, double note, string commentaire, string plateforme, int tempsJeu, string img, DateTime dateAjout, string developpeur, string genre)
        {
            Jeu jeu = new Jeu(utilisateur, titre, sortie, note, commentaire, plateforme, tempsJeu, img, dateAjout, developpeur, genre);
            connexionBDD.Ajout<Jeu>("Jeux", jeu);
        }

        /// <summary>
        /// Supprime une série dans la BDD
        /// </summary>
        /// <param name="serie"></param>
        public void SupprSerie(Serie serie)
        {
            connexionBDD.Suppr<Serie>("Séries", serie.Id);
        }

        /// <summary>
        /// Supprime un film dans la BDD
        /// </summary>
        /// <param name="film"></param>
        public void SupprFilm(Film film)
        {
            connexionBDD.Suppr<Film>("Films", film.Id);
        }

        /// <summary>
        /// Supprime un jeu dans la BDD
        /// </summary>
        /// <param name="jeu"></param>
        public void SupprJeu(Jeu jeu)
        {
            connexionBDD.Suppr<Jeu>("Jeux", jeu.Id);
        }

        public void UpdateSerie(Serie serie)
        {
            UpdateDefinition<Serie> update = Builders<Serie>.Update.Set("utilisateur", serie.utilisateur)
                                               .Set("titre", serie.titre)
                                               .Set("sortie", serie.sortie)
                                               .Set("saison", serie.saison)
                                               .Set("note", serie.note)
                                               .Set("commentaire", serie.commentaire)
                                               .Set("plateforme", serie.plateforme)
                                               .Set("img", serie.img)
                                               .Set("casting", serie.casting)
                                               .Set("genre", serie.genre)
                                               .Set("imdb", serie.imdb);
            connexionBDD.Update("Séries", serie.Id, update);
        }

        public void UpdateFilm(Film film)
        {
            UpdateDefinition<Film> update = Builders<Film>.Update.Set("utilisateur", film.utilisateur)
                                               .Set("titre", film.titre)
                                               .Set("duree", film.duree)
                                               .Set("sortie", film.sortie)
                                               .Set("casting", film.casting)
                                               .Set("note", film.note)
                                               .Set("commentaire", film.commentaire)
                                               .Set("plateforme", film.plateforme)
                                               .Set("img", film.img)
                                               .Set("realisateur", film.realisateur)
                                               .Set("genre", film.genre)
                                               .Set("imdb", film.imdb);
            connexionBDD.Update("Films", film.Id, update);
        }

        public void UpdateJeu(Jeu jeu)
        {
            UpdateDefinition<Jeu> update = Builders<Jeu>.Update.Set("utilisateur", jeu.utilisateur)
                                               .Set("titre", jeu.titre)
                                               .Set("sortie", jeu.sortie)
                                               .Set("tempsJeu", jeu.tempsJeu)
                                               .Set("note", jeu.note)
                                               .Set("commentaire", jeu.commentaire)
                                               .Set("plateforme", jeu.plateforme)
                                               .Set("img", jeu.img)
                                               .Set("developpeur", jeu.developpeur)
                                               .Set("genre", jeu.genre);
            connexionBDD.Update("Jeux", jeu.Id, update);
        }

        /// <summary>
        /// Retourne le chemin correspondant au dossier image de l'application
        /// </summary>
        /// <returns></returns>
        public string GetImageDirectory()
        {
            return imageDirectory;
        }

        /// <summary>
        /// Retourne le chemin correspondant au dossier image stocké en local
        /// </summary>
        /// <returns></returns>
        public string GetLocalImageDirectory()
        {
            return localImageDirectory;
        }

        /// <summary>
        /// Copie les images stockés dans l'application dans le dossier images locale
        /// </summary>
        public void CopyImagesToLocalDirectory()
        {
            if (!Directory.Exists(localImageDirectory))
            {
                Directory.CreateDirectory(localImageDirectory);
            }

            DirectoryInfo dirInfo = new DirectoryInfo(imageDirectory);
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo tempfile in files)
            {
                try
                {
                    tempfile.CopyTo(Path.Combine(localImageDirectory, tempfile.Name));
                }
                catch (Exception)
                {
                }
                             
            }           
        }

        /// <summary>
        /// Affiche le ToolTip en fonction du texte donnée en paramètre
        /// </summary>
        /// <param name="label"></param>
        /// <param name="btn"></param>
        public void SetToolTip(string label, Button btn)
        {
            t1.InitialDelay = 1000;
            t1.Show(label, btn);
        }
    }
}
