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
    public partial class FrmSeries : Form
    {
        Controle controle;
        FrmList frmList;
        private string type = "Série";
        private string tri = "DateDesc";
        private readonly BindingSource bdgSeries = new BindingSource();
        private List<Serie> lesSeries;
        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="controle"></param>
        public FrmSeries(Controle controle, FrmList frmList)
        {
            InitializeComponent();
            this.controle = controle;
            this.frmList = frmList;
        }
        private void FrmSeries_Load(object sender, EventArgs e)
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
            RemplirGridSeries(null);
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
        /// Récupère l'image correspondant à la série sélectionnée
        /// </summary>
        private void LoadImage(Serie serie)
        {
            imgSerie.Visible = true;
            imgSerie.ImageLocation = controle.GetImageDirectory() + serie.img;
        }

        private void LoadImageNote(Serie serie)
        {
            lblNote.Text = "Note : ";
            switch (serie.note)
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
        private void LoadPlateforme(Serie serie)
        {
            imgPlateforme.Visible = true;
            switch (serie.plateforme)
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
                case "Disney":
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
        private void RemplirGridSeries(string utilisateur)
        {
            dgvSeries.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            lesSeries = controle.GetSeries(utilisateur);
            if (lesSeries.Count != 0)
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
                dgvSeries.Visible = false;
                lblResultat.Text = "";
            }
        }

        private void AfficheGrid()
        {
            bdgSeries.DataSource = lesSeries;
            dgvSeries.DataSource = bdgSeries;
            if(radioClemence.Checked || radioLucas.Checked)
            {
                dgvSeries.Columns["utilisateur"].Visible = false;
            }
            else
            {
                dgvSeries.Columns["utilisateur"].Visible = true;
            }
            dgvSeries.Columns["Id"].Visible = false;
            dgvSeries.Columns["sortie"].Visible = false;
            dgvSeries.Columns["casting"].Visible = false;
            dgvSeries.Columns["genre"].Visible = false;
            dgvSeries.Columns["plateforme"].Visible = true;
            dgvSeries.Columns["commentaire"].Visible = false;
            dgvSeries.Columns["dateAjout"].Visible = false;
            dgvSeries.Columns["img"].Visible = false;
            dgvSeries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSeries.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dgvSeries.Visible = true;
            AfficheNbEnregistrements();
        }

        private void GestionTri(string tri)
        {
            switch (tri)
            {
                case "DateDesc":
                    lesSeries = lesSeries.OrderByDescending(o => o.dateAjout).ThenByDescending(o => o.note).ToList();
                    break;
                case "DateAsc":
                    lesSeries = lesSeries.OrderBy(o => o.dateAjout).ThenByDescending(o => o.note).ToList();
                    break;
                case "Note":
                    lesSeries = lesSeries.OrderByDescending(o => o.note).ThenByDescending(o => o.dateAjout).ToList();
                    break;
            }
        }

        /// <summary>
        /// Appelle la méthode qui change les affichages de la fiche à chaque changement de selection dans le datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSeries_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSeries.DataSource != null)
            {
                ChargementFiche();
            }
        }

        /// <summary>
        /// Gère la modification des affichages de la fiche série
        /// </summary>
        private void ChargementFiche()
        {
            Serie serie = (Serie)bdgSeries.List[bdgSeries.Position];
            lblTitre.Text = serie.titre;
            lblSaison.Text = serie.GetSaison();
            lblSortie.Text = serie.GetSortie();
            lblCasting.Text = serie.GetCasting();
            lblGenre.Text = serie.GetGenre();
            lblCommentaire.Text = serie.GetCommentaire();
            lblDate.Text = serie.GetDateAjout();
            lblUtilisateur.Text = serie.GetUtilisateur();
            LoadImage(serie);
            LoadPlateforme(serie);
            LoadImageNote(serie);
        }

        /// <summary>
        /// Affiche les séries de tous les utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioTous_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTous.Checked)
            {
                lesSeries.Clear();
                RemplirGridSeries(null);
            }
        }

        /// <summary>
        /// N'affiche que les séries de Clémence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioClemence_CheckedChanged(object sender, EventArgs e)
        {
            if (radioClemence.Checked)
            {
                lesSeries.Clear();
                RemplirGridSeries(radioClemence.Text);
            }
        }

        /// <summary>
        /// N'affiche que les séries de Lucas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioLucas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLucas.Checked)
            {
                lesSeries.Clear();
                RemplirGridSeries(radioLucas.Text);
            }
        }

        private void radioNote_CheckedChanged(object sender, EventArgs e)
        {
            tri = "Note";
            GestionTri(tri);
            AfficheGrid();
        }

        private void radioDateAsc_CheckedChanged(object sender, EventArgs e)
        {
            tri = "DateAsc";
            GestionTri(tri);
            AfficheGrid();
        }

        private void radioDateDesc_CheckedChanged(object sender, EventArgs e)
        {
            tri = "DateDesc";
            GestionTri(tri);
            AfficheGrid();
        }

        /// <summary>
        /// Permet d'ajouter une nouvelle série dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter"), sender);
        }

        /// <summary>
        /// Permet de modifier une série existante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Serie serie = (Serie)bdgSeries.List[bdgSeries.Position];
            frmList.OpenChildForm(new FrmAjout(controle, type, "Modifier", serie), sender);
        }

        /// <summary>
        /// Supprime une série de la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvSeries.SelectedRows.Count > 0)
            {
                Serie serie = (Serie)bdgSeries.List[bdgSeries.Position];
                if (MessageBox.Show("Voulez vous vraiment supprimer " + serie.titre + " saison " + serie.saison + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(controle.GetImageDirectory() + serie.img);
                    SupprSerie(serie);
                    RemplirGridSeries(null);
                }
            }
        }

        /// <summary>
        /// Appelle la methode qui supprime une série de la BDD
        /// </summary>
        /// <param name="serie"></param>
        private void SupprSerie(Serie serie)
        {
            controle.SupprSerie(serie);
        }

        private void ResetFiche()
        {
            lblTitre.Text = "";
            lblSortie.Text = "";
            lblNote.Text = "";
            lblCommentaire.Text = "";
            lblCasting.Text = "";
            lblGenre.Text = "";
            lblDate.Text = "";
            lblSaison.Text = "";
            lblPlateforme.Text = "";
            lblUtilisateur.Text = "";
            imgSerie.Visible = false;
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
            if (dgvSeries.RowCount > 1)
            {
                lblResultat.Text = dgvSeries.RowCount.ToString() + " séries enregistrées";
            }
            else
            {
                lblResultat.Text = dgvSeries.RowCount.ToString() + " série enregistrée";
            }
        }

    }
}
