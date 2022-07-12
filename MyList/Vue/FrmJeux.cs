using MyList.Controleur;
using MyList.Modele;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyList.Vue
{
    public partial class FrmJeux : Form
    {
        Controle controle;
        FrmList frmList;
        private string type = "Jeu Video";
        private string tri = "DateDesc";
        private readonly BindingSource bdgJeux = new BindingSource();
        private List<Jeu> lesJeux;
        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="controle"></param>
        public FrmJeux(Controle controle, FrmList frmList)
        {
            InitializeComponent();
            this.controle = controle;
            this.frmList = frmList;
        }
        private void FrmJeux_Load(object sender, EventArgs e)
        {
            ResetFiche();
            Init();
        }

        /// <summary>
        /// Methodes à appliquer lors du chargement du formulaire
        /// </summary>
        private void Init()
        {
            LoadTheme();
            RemplirGridJeux(null);
        }

        /// <summary>
        /// Chargement du thème de couleur du formulaire
        /// </summary>
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Récupère l'image correspondant au jeu sélectionné
        /// </summary>
        private void LoadImage(Jeu jeu)
        {
            if (bdgJeux.Count != -1)
            {
                imgJeu.Visible = true;
                imgJeu.ImageLocation = controle.GetImageDirectory() + jeu.img;
            }
        }

        /// <summary>
        /// Gère l'affiche des étoiles qui correspondent à la note
        /// </summary>
        /// <param name="jeu"></param>
        private void LoadImageNote(Jeu jeu)
        {
            lblNote.Text = "Note : ";
            switch (jeu.note)
            {
                case 0:
                    imgNote1.Visible = true;
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/redStar.png";
                    imgNote2.Visible = false;
                    imgNote3.Visible = false;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    break;
                case 1:
                    imgNote1.Visible = true;
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote2.Visible = false;
                    imgNote3.Visible = false;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    break;
                case 2:
                    imgNote1.Visible = true;
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote2.Visible = true;
                    imgNote3.Visible = false;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    break;
                case 3:
                    imgNote1.Visible = true;
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = false;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    break;
                case 4:
                    imgNote1.Visible = true;
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = true;
                    imgNote5.Visible = false;
                    imgNote6.Visible = false;
                    break;
                case 5:
                    imgNote1.Visible = true;
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = true;
                    imgNote5.Visible = true;
                    imgNote6.Visible = false;
                    break;
                case 6:
                    imgNote1.Visible = true;
                    imgNote1.ImageLocation = controle.GetImageDirectory() + "/logo/goldStar.png";
                    imgNote2.Visible = true;
                    imgNote3.Visible = true;
                    imgNote4.Visible = true;
                    imgNote5.Visible = true;
                    imgNote6.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Récupère l'image correspondant à la plateforme du film sélectionné
        /// </summary>
        private void LoadPlateforme(Jeu jeu)
        {
            imgPlateforme.Visible = true;
            switch (jeu.plateforme)
            {
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
        /// Remplissage du datagridview à partir du contenu de la BDD MongoDB
        /// </summary>
        /// <param name="utilisateur"></param>
        private void RemplirGridJeux(string utilisateur)
        {
            dgvJeux.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            lesJeux = controle.GetJeux(utilisateur);
            if (lesJeux.Count != 0)
            {
                grpTri.Visible = true;
                grpFiche.Visible = true;
                GestionTri(tri);
                AfficheGrid();
            }
            else
            {
                ResetFiche();
                grpTri.Visible = false;
                grpFiche.Visible = false;
                dgvJeux.Visible = false;
                lblResultat.Text = "";
            }
        }

        private void AfficheGrid()
        {
            bdgJeux.DataSource = lesJeux;
            dgvJeux.DataSource = bdgJeux;
            if (radioClemence.Checked || radioLucas.Checked)
            {
                dgvJeux.Columns["utilisateur"].Visible = false;
            }
            else
            {
                dgvJeux.Columns["utilisateur"].Visible = true;
            }
            dgvJeux.Columns["Id"].Visible = false;
            dgvJeux.Columns["sortie"].Visible = false;
            dgvJeux.Columns["commentaire"].Visible = false;
            dgvJeux.Columns["dateAjout"].Visible = false;
            dgvJeux.Columns["img"].Visible = false;
            dgvJeux.Columns["developpeur"].Visible = false;
            dgvJeux.Columns["genre"].Visible = false;
            dgvJeux.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvJeux.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dgvJeux.Visible = true;
            AfficheNbEnregistrements();
        }

        private void GestionTri(string tri)
        {
            switch (tri)
            {
                case "DateDesc":
                    lesJeux = lesJeux.OrderByDescending(o => o.dateAjout).ThenByDescending(o => o.note).ToList();
                    break;
                case "DateAsc":
                    lesJeux = lesJeux.OrderBy(o => o.dateAjout).ThenByDescending(o => o.note).ToList();
                    break;
                case "Note":
                    lesJeux = lesJeux.OrderByDescending(o => o.note).ThenByDescending(o => o.dateAjout).ToList();
                    break;
                case "Temps":
                    lesJeux = lesJeux.OrderByDescending(o => o.tempsJeu).ThenByDescending(o => o.dateAjout).ToList();
                    break;
            }
        }

        /// <summary>
        /// Appelle la méthode qui change les affichages de la fiche à chaque changement de selection dans le datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvJeux_SelectionChanged(object sender, EventArgs e)
        {
            ChargementFiche();
        }

        /// <summary>
        /// Gère la modification des affichages de la fiche jeu
        /// </summary>
        private void ChargementFiche()
        {
            Jeu jeu = (Jeu)bdgJeux.List[bdgJeux.Position];
            lblTitre.Text = jeu.titre;
            lblSortie.Text = jeu.GetSortie();
            lblDeveloppeur.Text = jeu.GetDeveloppeur();
            lblGenre.Text = jeu.GetGenre();
            lblCommentaire.Text = jeu.GetCommentaire();
            lblDate.Text = jeu.GetDateAjout();
            lblUtilisateur.Text = jeu.GetUtilisateur();
            lblTemps.Text = jeu.GetTempsJeu();
            LoadImage(jeu);
            LoadPlateforme(jeu);
            LoadImageNote(jeu);
        }

        /// <summary>
        /// Affiche les jeux de tous les utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioTous_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTous.Checked)
            {
                lesJeux.Clear();
                RemplirGridJeux(null);
            }
        }

        /// <summary>
        /// N'affiche que les jeux de Clémence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioClemence_CheckedChanged(object sender, EventArgs e)
        {
            if (radioClemence.Checked)
            {
                lesJeux.Clear();
                RemplirGridJeux(radioClemence.Text);
            }
        }

        /// <summary>
        /// N'affiche que les jeux de Lucas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioLucas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLucas.Checked)
            {
                lesJeux.Clear();
                RemplirGridJeux(radioLucas.Text);
            }
        }

        private void radioDateDesc_CheckedChanged(object sender, EventArgs e)
        {
            tri = "DateDesc";
            GestionTri(tri);
            AfficheGrid();
        }

        private void radioDateAsc_CheckedChanged(object sender, EventArgs e)
        {
            tri = "DateAsc";
            GestionTri(tri);
            AfficheGrid();
        }

        private void radioNote_CheckedChanged(object sender, EventArgs e)
        {
            tri = "Note";
            GestionTri(tri);
            AfficheGrid();
        }

        private void radioTime_CheckedChanged(object sender, EventArgs e)
        {
            tri = "Temps";
            GestionTri(tri);
            AfficheGrid();
        }

        /// <summary>
        /// Permet d'ajouter un nouveau jeu dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter"), sender);
        }

        /// <summary>
        /// Permet de modifier un jeu existant dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Jeu jeu = (Jeu)bdgJeux.List[bdgJeux.Position];
            frmList.OpenChildForm(new FrmAjout(controle, type, "Modifier", jeu), sender);
        }

        /// <summary>
        /// Supprime un jeu de la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvJeux.SelectedRows.Count > 0)
            {
                Jeu jeu = (Jeu)bdgJeux.List[bdgJeux.Position];
                if (MessageBox.Show("Voulez vous vraiment supprimer " + jeu.titre + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(controle.GetImageDirectory() + jeu.img);
                    SupprJeu(jeu);
                    RemplirGridJeux(null);
                }
            }
        }

        /// <summary>
        /// Appelle la methode qui supprime un jeu de la BDD
        /// </summary>
        /// <param name="serie"></param>
        private void SupprJeu(Jeu jeu)
        {
            controle.SupprJeu(jeu);
        }

        private void ResetFiche()
        {
            lblTitre.Text = "";
            lblSortie.Text = "";
            lblNote.Text = "";
            lblCommentaire.Text = "";
            lblDate.Text = "";
            lblTemps.Text = "";
            lblPlateforme.Text = "";
            lblUtilisateur.Text = "";
            imgJeu.Visible = false;
            imgPlateforme.Visible = false;
            imgNote1.Visible = false;
            imgNote2.Visible = false;
            imgNote3.Visible = false;
            imgNote4.Visible = false;
            imgNote5.Visible = false;
            imgNote6.Visible = false;
        }

        private void AfficheNbEnregistrements()
        {
            if (dgvJeux.RowCount > 1)
            {
                lblResultat.Text = dgvJeux.RowCount.ToString() + " jeux enregistrés";
            }
            else
            {
                lblResultat.Text = dgvJeux.RowCount.ToString() + " jeu enregistré";
            }
        }
    }
}
