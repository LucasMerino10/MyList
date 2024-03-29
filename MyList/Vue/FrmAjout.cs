﻿using MyList.Controleur;
using MyList.Modele;
using System;
using System.IO;
using System.Windows.Forms;

namespace MyList.Vue
{
    public partial class FrmAjout : Form
    {
        Controle controle;
        Object media;
        private string typeMedia;
        private string operation;
        private string caseFilm = "Durée : ";
        private string caseSerie = "Saison ";
        private string caseJeu = "Temps de jeu : ";
        private string cheminImage;
        private string image;
        private string ext;
        private int imgIndex = 0;

        /// <summary>
        /// Constructeur pour un Ajout
        /// </summary>
        /// <param name="controle"></param>
        /// <param name="type"></param>
        public FrmAjout(Controle controle, string type, string operation)
        {
            Init(controle, type, operation, null);
        }

        public FrmAjout(Controle controle, string type, string operation, Object media)
        {
            Init(controle, type, operation, media);
        }

        private void Init(Controle controle, string type, string operation, Object media)
        {
            InitializeComponent();
            this.typeMedia = type;
            this.controle = controle;
            this.operation = operation;
            if (media != null)
            {
                this.media = media;
            }
        }
        private void FrmAjout_Load(object sender, EventArgs e)
        {
            if (media != null)
            {
                DetectionMedia(media);
                radioFilm.Visible = false;
                radioJeu.Visible = false;
                radioSérie.Visible = false;
            }
            else
            {
                DetectionMedia();
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (operation == "Ajouter" || operation == "Ajouter une suite")
            {
                if (lblImage.Text != "")
                {
                    SaveImage();
                    if (cboUtilisateur.Text != "" && txtBoxTitre.Text != "" && txtBoxSpe.Text != "" && txtBoxSortie.Text != "" && cboNote.Text != "" && cboPlateforme.Text != "")
                    {
                        try
                        {
                            switch (typeMedia)
                            {
                                case "Film":
                                    controle.AjoutFilm(cboUtilisateur.Text, txtBoxTitre.Text, int.Parse(txtBoxSpe.Text), int.Parse(txtBoxSortie.Text), txtBoxCasting.Text, double.Parse(cboNote.Text), txtBoxCommentaire.Text, cboPlateforme.Text, image + ext, DateTime.Now, txtRealisateur.Text, txtGenre.Text, txtImdb.Text);
                                    break;
                                case "Série":
                                    controle.AjoutSerie(cboUtilisateur.Text, txtBoxTitre.Text, int.Parse(txtBoxSortie.Text), int.Parse(txtBoxSpe.Text), double.Parse(cboNote.Text), txtBoxCommentaire.Text, cboPlateforme.Text, DateTime.Now, image + ext, txtBoxCasting.Text, txtGenre.Text, txtImdb.Text);
                                    break;
                                case "Jeu Video":
                                    controle.AjoutJeu(cboUtilisateur.Text, txtBoxTitre.Text, int.Parse(txtBoxSortie.Text), double.Parse(cboNote.Text), txtBoxCommentaire.Text, cboPlateforme.Text, int.Parse(txtBoxSpe.Text), image + ext, DateTime.Now, txtRealisateur.Text, txtGenre.Text);
                                    break;
                            }
                            MessageBox.Show("Fiche ajoutée avec succès!", "Succès");
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Mauvaise saisie. Utilisez des chiffres pour la date de sortie, la saison, le temps de jeu et la durée d'un film.", "Erreur");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Champ obligatoire non reseigné", "Erreur");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez ajouter une image", "Erreur");
                }
            }
            else
            {
                if (cboUtilisateur.Text != "" && txtBoxTitre.Text != "" && txtBoxSpe.Text != "" && txtBoxSortie.Text != "" && cboNote.Text != "" && cboPlateforme.Text != "")
                {
                    try
                    {
                        switch (typeMedia)
                        {
                            case "Film":
                                ModifFilm((Film)media);
                                controle.UpdateFilm((Film)media);
                                break;
                            case "Série":
                                ModifSerie((Serie)media);
                                controle.UpdateSerie((Serie)media);
                                break;
                            case "Jeu Video":
                                ModifJeu((Jeu)media);
                                controle.UpdateJeu((Jeu)media);
                                break;
                        }
                        MessageBox.Show("Fiche modifiée avec succès!", "Succès");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Mauvaise saisie, utilisez des chiffres pour la date de sortie, la saison, le temps de jeu et la durée d'un film.", "Erreur");
                    }
                }
                else
                {
                    MessageBox.Show("Champ obligatoire non reseigné", "Erreur");
                }
            }
        }



        private void DetectionMedia(Object media)
        {
            switch (typeMedia)
            {
                case "Film":
                    radioFilm.Checked = true;
                    Film film = (Film)media;
                    if (operation == "Modifier")
                    {
                        LoadFilm(film);
                    }
                    else
                    {
                        LoadBaseFilm(film);
                    }
                    break;
                case "Série":
                    radioSérie.Checked = true;
                    Serie serie = (Serie)media;
                    if (operation == "Modifier")
                    {
                        LoadSerie(serie);
                    }
                    else
                    {
                        LoadBaseSerie(serie);
                    }
                    break;
                case "Jeu Video":
                    radioJeu.Checked = true;
                    Jeu jeu = (Jeu)media;
                    if (operation == "Modifier")
                    {
                        LoadJeu(jeu);
                    }
                    else
                    {
                        LoadBaseJeu(jeu);
                    }
                    break;
            }
        }

        private void DetectionMedia()
        {
            switch (typeMedia)
            {
                case "Film":
                    radioFilm.Checked = true;
                    break;
                case "Série":
                    radioSérie.Checked = true;
                    break;
                case "Jeu Video":
                    radioJeu.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Pré-rempli les informations de bases pour l'ajout d'une suite
        /// </summary>
        /// <param name="serie"></param>
        private void LoadBaseSerie(Serie serie)
        {
            int saison = serie.saison + 1;
            cboUtilisateur.SelectedItem = serie.utilisateur;
            txtBoxTitre.Text = serie.titre;
            txtGenre.Text = serie.genre;
            txtBoxSpe.Text = saison.ToString();
            cboPlateforme.SelectedItem = serie.plateforme;
            txtBoxCasting.Text = serie.casting;
        }

        /// <summary>
        /// Rempli toutes les informations pour une modification 
        /// </summary>
        /// <param name="serie"></param>
        private void LoadSerie(Serie serie)
        {
            LoadBaseSerie(serie);
            txtBoxSortie.Text = serie.sortie.ToString();                     
            cboNote.SelectedItem = serie.note.ToString();
            txtBoxCommentaire.Text = serie.commentaire;           
            lblImage.Text = serie.img;
            txtImdb.Text = serie.imdb;
            LoadImageFiche();
        }

        /// <summary>
        /// Pré-rempli les informations de bases pour l'ajout d'une suite
        /// </summary>
        /// <param name="serie"></param>
        private void LoadBaseJeu(Jeu jeu)
        {
            cboUtilisateur.SelectedItem = jeu.utilisateur;
            txtBoxTitre.Text = jeu.titre;
            txtRealisateur.Text = jeu.developpeur;
            txtGenre.Text = jeu.genre;
            cboPlateforme.SelectedItem = jeu.plateforme;
        }

        /// <summary>
        /// Rempli toutes les informations pour une modification 
        /// </summary>
        /// <param name="jeu"></param>
        private void LoadJeu(Jeu jeu)
        {
            LoadBaseJeu(jeu);
            txtBoxSortie.Text = jeu.sortie.ToString();
            txtBoxSpe.Text = jeu.tempsJeu.ToString();
            cboNote.SelectedItem = jeu.note.ToString();
            txtBoxCommentaire.Text = jeu.commentaire;
            lblImage.Text = jeu.img;
            LoadImageFiche();
        }

        /// <summary>
        /// Pré-rempli les informations de bases pour l'ajout d'une suite
        /// </summary>
        /// <param name="serie"></param>
        private void LoadBaseFilm(Film film)
        {
            cboUtilisateur.SelectedItem = film.utilisateur;
            txtBoxTitre.Text = film.titre;
            txtRealisateur.Text = film.realisateur;
            txtGenre.Text = film.genre;
            cboPlateforme.SelectedItem = film.plateforme;
            txtBoxCasting.Text = film.casting;
        }

        /// <summary>
        /// Rempli toutes les informations pour une modification 
        /// </summary>
        /// <param name="film"></param>
        private void LoadFilm(Film film)
        {
            LoadBaseFilm(film);
            txtBoxSpe.Text = film.duree.ToString();
            txtBoxSortie.Text = film.sortie.ToString();
            cboNote.SelectedItem = film.note.ToString();            
            txtBoxCommentaire.Text = film.commentaire;
            lblImage.Text = film.img;
            txtImdb.Text = film.imdb;
            LoadImageFiche();
        }

        private void ModifSerie(Serie serie)
        {
            serie.utilisateur = cboUtilisateur.Text;
            serie.titre = txtBoxTitre.Text;
            serie.casting = txtBoxCasting.Text;
            serie.genre = txtGenre.Text;
            serie.sortie = int.Parse(txtBoxSortie.Text);
            serie.saison = int.Parse(txtBoxSpe.Text);
            serie.note = double.Parse(cboNote.Text);
            serie.commentaire = txtBoxCommentaire.Text;
            serie.plateforme = cboPlateforme.Text;
            serie.imdb = txtImdb.Text;
            if (ChangementImage(serie.img))
            {
                File.Delete(controle.GetImageDirectory() + serie.img);
                File.Delete(controle.GetLocalImageDirectory() + serie.img);
                SaveImage();
                serie.img = image + ext;
            }
        }

        private void ModifFilm(Film film)
        {
            film.utilisateur = cboUtilisateur.Text;
            film.titre = txtBoxTitre.Text;
            film.realisateur = txtRealisateur.Text;
            film.genre = txtGenre.Text;
            film.sortie = int.Parse(txtBoxSortie.Text);
            film.duree = int.Parse(txtBoxSpe.Text);
            film.note = double.Parse(cboNote.Text);
            film.casting = txtBoxCasting.Text;
            film.commentaire = txtBoxCommentaire.Text;
            film.plateforme = cboPlateforme.Text;
            film.imdb = txtImdb.Text;
            if (ChangementImage(film.img))
            {
                File.Delete(controle.GetImageDirectory() + film.img);
                File.Delete(controle.GetLocalImageDirectory() + film.img);
                SaveImage();
                film.img = image + ext;
            }
        }

        private void ModifJeu(Jeu jeu)
        {
            jeu.utilisateur = cboUtilisateur.Text;
            jeu.titre = txtBoxTitre.Text;
            jeu.genre = txtGenre.Text;
            jeu.developpeur = txtRealisateur.Text;
            jeu.sortie = int.Parse(txtBoxSortie.Text);
            jeu.tempsJeu = int.Parse(txtBoxSpe.Text);
            jeu.note = double.Parse(cboNote.Text);
            jeu.commentaire = txtBoxCommentaire.Text;
            jeu.plateforme = cboPlateforme.Text;
            if (ChangementImage(jeu.img))
            {
                File.Delete(controle.GetImageDirectory() + jeu.img);
                File.Delete(controle.GetLocalImageDirectory() + jeu.img);
                SaveImage();
                jeu.img = image + ext;
            }
        }

        private bool ChangementImage(string image)
        {
            if (image != lblImage.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void radioFilm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFilm.Checked)
            {
                typeMedia = "Film";
                lblSpecialInfo.Text = "Durée (min)* :";
                lblSpecialFiche.Text = caseFilm;
                lblCastingInfo.Visible = true;
                txtBoxCasting.Visible = true;
                lblCastingFiche.Visible = true;
                lblRealisateurFiche.Visible = true;
                lblRealisateurFiche.Text = "Réalisateur : ";
                lblRealisateurInfo.Visible = true;
                lblRealisateurInfo.Text = "Réalisateur :";
                txtRealisateur.Visible = true;
                lblImdb.Visible = true;
                txtImdb.Visible = true;
                ResetFiche();
                RemplirComboPlateforme();
            }
        }

        private void radioSérie_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSérie.Checked)
            {
                typeMedia = "Série";
                lblSpecialInfo.Text = "N° de saison* :";
                lblSpecialFiche.Text = caseSerie;
                lblCastingInfo.Visible = true;
                lblRealisateurFiche.Visible = false;
                lblRealisateurInfo.Visible = false;
                txtRealisateur.Visible = false;
                txtBoxCasting.Visible = true;
                lblCastingFiche.Visible = true;
                lblImdb.Visible = true;
                txtImdb.Visible = true;
                ResetFiche();
                RemplirComboPlateforme();
            }
        }

        private void radioJeu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioJeu.Checked)
            {
                typeMedia = "Jeu Video";
                lblSpecialInfo.Text = "Heures de jeu* :";
                lblSpecialFiche.Text = caseJeu;
                lblCastingInfo.Visible = false;
                lblRealisateurFiche.Visible = true;
                lblRealisateurFiche.Text = "Développeur : ";
                lblRealisateurInfo.Visible = true;
                lblRealisateurInfo.Text = "Développeur : ";
                txtRealisateur.Visible = true;
                txtBoxCasting.Visible = false;
                lblCastingFiche.Visible = false;
                lblImdb.Visible = false;
                txtImdb.Visible = false;
                ResetFiche();
                RemplirComboPlateforme();
            }
        }

        private void RemplirComboPlateforme()
        {
            cboPlateforme.SelectedIndex = -1;
            cboPlateforme.Items.Clear();
            if (radioFilm.Checked || radioSérie.Checked)
            {
                cboPlateforme.Items.Add("Netflix");
                cboPlateforme.Items.Add("Prime Video");
                cboPlateforme.Items.Add("Disney+");
                cboPlateforme.Items.Add("OCS");
                cboPlateforme.Items.Add("Autre");
            }
            else
            {
                cboPlateforme.Items.Add("Steam");
                cboPlateforme.Items.Add("PS5");
                cboPlateforme.Items.Add("PS4");
                cboPlateforme.Items.Add("Epic Games");
                cboPlateforme.Items.Add("Gog");
                cboPlateforme.Items.Add("Origin");
                cboPlateforme.Items.Add("Xbox Gamepass");
                cboPlateforme.Items.Add("Uplay");
                cboPlateforme.Items.Add("Cracked");
            }
        }

        /// <summary>
        /// Récupère l'image correspondant à la plateforme du film sélectionné
        /// </summary>
        private void LoadPlateforme(string plateforme)
        {
            imgPlateforme.Visible = true;
            switch (plateforme)
            {
                case "Autre":
                    lblPlateforme.Text = "";
                    imgPlateforme.Visible = false;
                    break;
                case "Netflix":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/netflix.png";
                    break;
                case "OCS":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/ocs.png";
                    break;
                case "Disney+":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/disney.png";
                    break;
                case "Prime Video":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/amazon.png";
                    break;
                case "Cracked":
                    lblPlateforme.Text = "Plateforme : Cracked";
                    imgPlateforme.Visible = false;
                    break;
                case "Steam":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/steam.png";
                    break;
                case "PS5":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/ps5.png";
                    break;
                case "PS4":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/ps4.png";
                    break;
                case "Uplay":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/uplay.png";
                    break;
                case "Origin":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/origin.png";
                    break;
                case "Gog":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/gog.png";
                    break;
                case "Xbox Gamepass":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/gamepass.png";
                    break;
                case "Epic Games":
                    lblPlateforme.Text = "Plateforme : ";
                    imgPlateforme.ImageLocation = controle.GetImageDirectory() + "/logo/epicgames.png";
                    break;
            }
        }

        /// <summary>
        /// Gère l'affiche des étoiles qui correspondent à la note
        /// </summary>
        /// <param name="jeu"></param>
        private void LoadImageNote(double note)
        {
            int full = imgNote1.Width;
            int semi = imgNote1.Width / 2;
            switch (note)
            {
                case 0:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/redStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = false;
                    imgNote3.Visible = false;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    break;
                case 1:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = false;
                    imgNote3.Visible = false;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    break;
                case 1.5:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = false;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    imgNote2.Width = semi;
                    break;
                case 2:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = false;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    imgNote2.Width = full;
                    break;
                case 2.5:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    imgNote3.Width = semi;
                    break;
                case 3:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    imgNote2.Width = full;
                    imgNote3.Width = full;
                    break;
                case 3.5:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = true;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    imgNote2.Width = full;
                    imgNote4.Width = semi;
                    break;
                case 4:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = true;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    imgNote2.Width = full;
                    imgNote3.Width = full;
                    imgNote4.Width = full;
                    break;
                case 4.5:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = true;
                    imgNote5.Visible = true;
                    imgNote6.Visible = false;
                    imgNote2.Width = full;
                    imgNote3.Width = full;
                    imgNote5.Width = semi;
                    break;
                case 5:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = true;
                    imgNote5.Visible = true;
                    imgNote6.Visible = false;
                    imgNote2.Width = full;
                    imgNote3.Width = full;
                    imgNote4.Width = full;
                    imgNote5.Width = full;
                    break;
                case 6:
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote1.Visible = true;
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = true;
                    imgNote5.Visible = true;
                    imgNote6.Visible = true;
                    imgNote2.Width = full;
                    imgNote3.Width = full;
                    imgNote4.Width = full;
                    imgNote5.Width = full;
                    break;
            }
        }
        private void ResetFiche()
        {
            txtBoxSpe.Text = "";
            txtBoxSpe_TextChanged(null, null);
            imgPlateforme.Image = null;
        }

        private void txtBoxTitre_TextChanged(object sender, EventArgs e)
        {
            lblTitre.Text = txtBoxTitre.Text;
        }

        private void txtBoxSpe_TextChanged(object sender, EventArgs e)
        {
            switch (typeMedia)
            {
                case "Film":
                    lblSpecialFiche.Text = caseFilm + txtBoxSpe.Text + " min";
                    break;
                case "Série":
                    lblSpecialFiche.Text = caseSerie + txtBoxSpe.Text;
                    break;
                case "Jeu Video":
                    lblSpecialFiche.Text = caseJeu + txtBoxSpe.Text + " h";
                    break;
            }

        }

        private void txtBoxSortie_TextChanged(object sender, EventArgs e)
        {
            lblSortie.Text = "Année de sortie : " + txtBoxSortie.Text;
        }

        private void cboPlateforme_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlateforme(cboPlateforme.Text);
        }

        private void cboNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadImageNote(double.Parse(cboNote.Text));
        }

        private void txtBoxCasting_TextChanged(object sender, EventArgs e)
        {
            lblCastingFiche.Text = "Casting : " + txtBoxCasting.Text;
        }

        private void txtBoxCommentaire_TextChanged(object sender, EventArgs e)
        {
            lblCommentaire.Text = "Commentaire : " + txtBoxCommentaire.Text;
        }

        private void txtRealisateur_TextChanged(object sender, EventArgs e)
        {
            if (radioFilm.Checked)
            {
                lblRealisateurFiche.Text = "Réalisateur : " + txtRealisateur.Text;
            }
            else
            {
                lblRealisateurFiche.Text = "Développeur : " + txtRealisateur.Text;
            }
            
        }

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {
            lblGenre.Text = "Genre(s) : " + txtGenre.Text;
        }

        /// <summary>
        /// Permet de selectionner et afficher l'image à sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Selectionner une image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cheminImage = dialog.FileName;
                image = Path.GetFileName(cheminImage);
                ext = GetExtension(image);
                lblImage.Text = image;
                imgFiche.ImageLocation = cheminImage;
            }
        }

        /// <summary>
        /// Sauvegarde l'image selectionnée dans l'application
        /// </summary>
        private void SaveImage()
        {
            if (txtBoxTitre.Text.Contains(":"))
            {
                image = cboUtilisateur.Text + txtBoxSortie.Text;
                while (File.Exists(controle.GetImageDirectory() + image + ext))
                {
                    image += imgIndex;
                    imgIndex++;
                }
                File.Copy(cheminImage, Path.Combine(controle.GetImageDirectory(), image + ext));
                File.Copy(cheminImage, Path.Combine(controle.GetLocalImageDirectory(), image + ext));
            }
            else
            {
                if (radioSérie.Checked)
                {
                    image = txtBoxTitre.Text + txtBoxSpe.Text + cboUtilisateur.Text;
                    while (File.Exists(controle.GetImageDirectory() + image + ext))
                    {
                        image += imgIndex;
                        imgIndex++;
                    }
                    File.Copy(cheminImage, Path.Combine(controle.GetImageDirectory(), image + ext));
                    File.Copy(cheminImage, Path.Combine(controle.GetLocalImageDirectory(), image + ext));
                }
                else
                {
                    image = txtBoxTitre.Text + cboUtilisateur.Text;
                    while (File.Exists(controle.GetImageDirectory() + image + ext))
                    {
                        image += imgIndex;
                        imgIndex++;
                    }
                    File.Copy(cheminImage, Path.Combine(controle.GetImageDirectory(), image + ext));
                    File.Copy(cheminImage, Path.Combine(controle.GetLocalImageDirectory(), image + ext));
                }
            }
        }

        private void LoadImageFiche()
        {
            imgFiche.ImageLocation = controle.GetLocalImageDirectory() + lblImage.Text;
        }

        /// <summary>
        /// Récupère l'extension du fichier image selectionné
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string GetExtension(string file)
        {
            return Path.GetExtension(file);
        }
        
    }
}
