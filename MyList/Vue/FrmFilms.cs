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
    public partial class FrmFilms : Form
    {
        Controle controle;
        FrmList frmList;
        private string type = "Film";
        private string tri = "DateDesc";
        private readonly BindingSource bdgFilms = new BindingSource();
        private List<Film> lesFilms;

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="controle"></param>
        public FrmFilms(Controle controle, FrmList frmList)
        {
            InitializeComponent();
            this.controle = controle;
            this.frmList = frmList;
        }
        private void FrmFilms_Load(object sender, EventArgs e)
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
            RemplirGridFilms(null);
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
        /// Récupère l'image correspondant au film sélectionné
        /// </summary>
        private void LoadImage(Film film)
        {
            imgFilm.Visible = true;
            imgFilm.ImageLocation = controle.GetImageDirectory() + film.img;
        }

        private void LoadImageNote(Film film)
        {
            lblNote.Text = "Note : ";
            switch (film.note)
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
        private void LoadPlateforme(Film film)
        {
            imgPlateforme.Visible = true;
            switch (film.plateforme)
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
            }
        }

        /// <summary>
        /// Remplissage du datagridview à partir du contenu de la BDD MongoDB
        /// </summary>
        /// <param name="utilisateur"></param>
        private void RemplirGridFilms(string utilisateur)
        {
            dgvFilms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            lesFilms = controle.GetFilms(utilisateur);
            if (lesFilms.Count != 0)
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
                dgvFilms.Visible = false;
                lblResultat.Text = "";
            }
        }

        private void AfficheGrid()
        {
            bdgFilms.DataSource = lesFilms;
            dgvFilms.DataSource = bdgFilms;
            if (radioClemence.Checked || radioLucas.Checked)
            {
                dgvFilms.Columns["utilisateur"].Visible = false;
            }
            else
            {
                dgvFilms.Columns["utilisateur"].Visible = true;
            }
            dgvFilms.Columns["Id"].Visible = false;
            dgvFilms.Columns["duree"].Visible = false;
            dgvFilms.Columns["plateforme"].Visible = true;
            dgvFilms.Columns["commentaire"].Visible = false;
            dgvFilms.Columns["dateAjout"].Visible = false;
            dgvFilms.Columns["casting"].Visible = false;
            dgvFilms.Columns["img"].Visible = false;
            dgvFilms.Columns["realisateur"].Visible = true;
            dgvFilms.Columns["genre"].Visible = false;
            dgvFilms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFilms.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dgvFilms.Visible = true;
            AfficheNbEnregistrements();
        }

        private void GestionTri(string tri)
        {
            switch (tri)
            {
                case "DateDesc":
                    lesFilms = lesFilms.OrderByDescending(o => o.dateAjout).ThenByDescending(o => o.note).ToList();
                    break;
                case "DateAsc":
                    lesFilms = lesFilms.OrderBy(o => o.dateAjout).ThenByDescending(o => o.note).ToList();
                    break;
                case "SortieAsc":
                    lesFilms = lesFilms.OrderBy(o => o.sortie).ThenByDescending(o => o.dateAjout).ToList();
                    break;
                case "SortieDesc":
                    lesFilms = lesFilms.OrderByDescending(o => o.sortie).ThenByDescending(o => o.dateAjout).ToList();
                    break;
                case "Note":
                    lesFilms = lesFilms.OrderByDescending(o => o.note).ThenByDescending(o => o.dateAjout).ToList();
                    break;
            }
        }

        /// <summary>
        /// Appelle la méthode qui change les affichages de la fiche à chaque changement de selection dans le datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFilms_SelectionChanged(object sender, EventArgs e)
        {
            ChargementFiche();
        }

        /// <summary>
        /// Gère la modification des affichages de la fiche film
        /// </summary>
        private void ChargementFiche()
        {
            Film film = (Film)bdgFilms.List[bdgFilms.Position];
            lblTitre.Text = film.titre;
            lblDuree.Text = film.GetDuree();
            lblCasting.Text = film.GetCasting();
            lblSortie.Text = film.GetSortie();
            lblCommentaire.Text = film.GetCommentaire();
            lblDate.Text = film.GetDateAjout();
            lblUtilisateur.Text = film.GetUtilisateur();
            lblRealisateur.Text = film.GetRealisateur();
            lblGenre.Text = film.GetGenre();
            LoadImage(film);
            LoadPlateforme(film);
            LoadImageNote(film);
        }

        /// <summary>
        /// Affiche les films de tous les utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioTous_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTous.Checked)
            {
                lesFilms.Clear();
                RemplirGridFilms(null);
            }
        }

        /// <summary>
        /// N'affiche que les films de Clémence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioClemence_CheckedChanged(object sender, EventArgs e)
        {
            if (radioClemence.Checked)
            {
                lesFilms.Clear();
                RemplirGridFilms(radioClemence.Text);
            }
        }

        /// <summary>
        /// N'affiche que les films de Lucas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioLucas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLucas.Checked)
            {
                lesFilms.Clear();
                RemplirGridFilms(radioLucas.Text);
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

        private void radioSortieAsc_CheckedChanged(object sender, EventArgs e)
        {
            tri = "SortieAsc";
            GestionTri(tri);
            AfficheGrid();
        }

        private void radioSortieDesc_CheckedChanged(object sender, EventArgs e)
        {
            tri = "SortieDesc";
            GestionTri(tri);
            AfficheGrid();
        }

        /// <summary>
        /// Permet d'ajouter un film dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter"), sender);
        }

        /// <summary>
        /// Permet de modifier un film existant dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Film film = (Film)bdgFilms.List[bdgFilms.Position];
            frmList.OpenChildForm(new FrmAjout(controle, type, "Modifier", film), sender);
        }

        /// <summary>
        /// Supprime un jeu de la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvFilms.SelectedRows.Count > 0)
            {
                Film film = (Film)bdgFilms.List[bdgFilms.Position];
                if (MessageBox.Show("Voulez vous vraiment supprimer " + film.titre + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(controle.GetImageDirectory() + film.img);
                    SupprJeu(film);
                    RemplirGridFilms(null);
                }
            }
        }

        /// <summary>
        /// Appelle la methode qui supprime un film de la BDD
        /// </summary>
        /// <param name="serie"></param>
        private void SupprJeu(Film film)
        {
            controle.SupprFilm(film);
        }

        private void ResetFiche()
        {
            lblTitre.Text = "";
            lblSortie.Text = "";
            lblNote.Text = "";
            lblCasting.Text = "";
            lblCommentaire.Text = "";
            lblDate.Text = "";
            lblDuree.Text = "";
            lblPlateforme.Text = "";
            lblUtilisateur.Text = "";
            lblRealisateur.Text = "";
            lblGenre.Text = "";
            imgFilm.Visible = false;
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
            if (dgvFilms.RowCount > 1)
            {
                lblResultat.Text = dgvFilms.RowCount.ToString() + " films enrigistrés";
            }
            else
            {
                lblResultat.Text = dgvFilms.RowCount.ToString() + " film enrigistré";
            }
        }
    }
}
