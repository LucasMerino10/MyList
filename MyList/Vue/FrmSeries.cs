using MyList.Controleur;
using MyList.Modele;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Methodes à appliquer lors du chargement du formulaire
        /// </summary>
        private void Init()
        {
            LoadTheme();
            cmbAnnee.SelectedIndex = 1;
            RemplirGridSeries(null, cmbAnnee.Text, null);
        }

        /// <summary>
        /// Chargement du thème de couleur du formulaire
        /// </summary>
        private void LoadTheme()
        {
            /**
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                }
            }
            */
            lblImdb.LinkColor = ThemeColor.PrimaryColor;
        }

        /// <summary>
        /// Récupère l'image correspondant à la série sélectionnée
        /// </summary>
        private void LoadImage(Serie serie)
        {
            imgSerie.Visible = true;
            imgSerie.ImageLocation = controle.GetLocalImageDirectory() + serie.img;
        }

        private void LoadImageNote(Serie serie)
        {
            int full = imgNote1.Width;
            int semi = imgNote1.Width / 2;
            lblNote.Text = "Note : ";
            switch (serie.note)
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
                    imgNote2.Width = full;
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
                    imgNote3.Width = full;
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
                    imgNote4.Width = full;
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
        private void RemplirGridSeries(string utilisateur, string annee, string titre)
        {
            dgvSeries.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            lesSeries = controle.GetSeries(utilisateur, annee, titre);
            if (lesSeries.Count != 0)
            {
                grpFiche.Visible = true;
                Sort("dateAjout", SortOrder.None);
            }
            else
            {
                ResetFiche();
                grpFiche.Visible = false;
                dgvSeries.Visible = false;
                lblResultat.Text = "";
            }
        }

        /// <summary>
        /// Gère l'affichage des différents champs de la BDD dans le DataGridView
        /// </summary>
        private void AfficheGrid()
        {
            bdgSeries.DataSource = lesSeries;
            dgvSeries.DataSource = bdgSeries;            
            dgvSeries.Columns["Id"].Visible = false;
            dgvSeries.Columns["utilisateur"].Visible = false;
            dgvSeries.Columns["sortie"].Visible = false;
            dgvSeries.Columns["casting"].Visible = false;
            dgvSeries.Columns["genre"].Visible = false;
            dgvSeries.Columns["plateforme"].Visible = false;
            dgvSeries.Columns["commentaire"].Visible = false;
            dgvSeries.Columns["img"].Visible = false;
            dgvSeries.Columns["imdb"].Visible = false;
            dgvSeries.Columns["titre"].HeaderText = "Titre";
            dgvSeries.Columns["saison"].HeaderText = "Saison";
            dgvSeries.Columns["note"].HeaderText = "Note";
            dgvSeries.Columns["dateAjout"].HeaderText = "Date";
            dgvSeries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSeries.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            foreach (DataGridViewColumn col in dgvSeries.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            dgvSeries.Visible = true;
            AfficheNbEnregistrements();
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
            if (serie.imdb == null || serie.imdb == "")
            {
                lblImdb.Visible = false;
            }
            else
            {
                lblImdb.Visible = true;
            }
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
                RemplirGridSeries(null, cmbAnnee.Text, txtRecherche.Text);
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
                RemplirGridSeries(radioClemence.Text, cmbAnnee.Text, txtRecherche.Text);
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
                RemplirGridSeries(radioLucas.Text, cmbAnnee.Text, txtRecherche.Text);
            }
        }

        /// <summary>
        /// Permet d'ajouter une nouvelle série dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter"), sender);
        }

        /// <summary>
        /// Permet de modifier une série existante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
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
                    File.Delete(controle.GetLocalImageDirectory() + serie.img);
                    SupprSerie(serie);
                    RemplirGridSeries(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
                }
            }
        }

        private void btnSequel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Serie serie = (Serie)bdgSeries.List[bdgSeries.Position];
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter une suite", serie), sender);
        }

        /// <summary>
        /// Appelle la methode qui supprime une série de la BDD
        /// </summary>
        /// <param name="serie"></param>
        private void SupprSerie(Serie serie)
        {
            controle.SupprSerie(serie);
        }

        /// <summary>
        /// Vide les informations de la fiche
        /// </summary>
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
            imgSerie.Visible = false;
            imgPlateforme.Visible = false;
            imgNote1.Visible = false;
            imgNote2.Visible = false;
            imgNote3.Visible = false;
            imgNote4.Visible = false;
            imgNote5.Visible = false;
            imgNote6.Visible = false;
            lblImdb.Visible = false;
        }

        /// <summary>
        /// Affiche le nombre d'enregistrements affiché dans le DataGridView
        /// </summary>
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

        /// <summary>
        /// Gère le clic sur un header du DataGridView, déclenche le tri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSeries_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            if (grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                so = SortOrder.Descending;
            }
            else
            {
                so = SortOrder.Ascending;
            }
            Sort(grid.Columns[e.ColumnIndex].Name, so);
            grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = so;
        }

        /// <summary>
        /// Gère le tri du DataGridView après un clic sur un header
        /// </summary>
        /// <param name="column"></param>
        /// <param name="sortOrder"></param>
        private void Sort(string column, SortOrder sortOrder)
        {
            switch (column)
            {
                case "titre":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesSeries = lesSeries.OrderBy(o => o.titre).ToList();
                    }
                    else
                    {
                        lesSeries = lesSeries.OrderByDescending(o => o.titre).ToList();
                    }
                    AfficheGrid();
                    break;
                case "note":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesSeries = lesSeries.OrderBy(o => o.note).ToList();
                    }
                    else
                    {
                        lesSeries = lesSeries.OrderByDescending(o => o.note).ToList();
                    }
                    AfficheGrid();
                    break;
                case "saison":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesSeries = lesSeries.OrderBy(o => o.saison).ToList();
                    }
                    else
                    {
                        lesSeries = lesSeries.OrderByDescending(o => o.saison).ToList();
                    }
                    AfficheGrid();
                    break;                
                case "dateAjout":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesSeries = lesSeries.OrderBy(o => o.dateAjout).ToList();
                    }
                    else
                    {
                        lesSeries = lesSeries.OrderByDescending(o => o.dateAjout).ToList();
                    }
                    AfficheGrid();
                    break;
            }
        }

        /// <summary>
        /// Gère le changement de police sur la ligne séléctionnée dans le DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSeries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            }
        }

        /// <summary>
        /// Redirection vers IMDB lors du clic sur le lien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblImdb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Serie serie = (Serie)bdgSeries.List[bdgSeries.Position];
            try
            {
                Process.Start(serie.imdb);
            }
            catch (Exception)
            {
                MessageBox.Show("Oups! Mauvais lien renseigné.", "Erreur");
            }
        }

        private void imgSerie_Click(object sender, EventArgs e)
        {
            Process.Start(imgSerie.ImageLocation);
        }

        private void cmbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirGridSeries(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
        }
      

        /// <summary>
        /// Gère l'affichage du ToolTip sur le bouton Ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_MouseHover(object sender, EventArgs e)
        {
            controle.SetToolTip("Ajouter", (Button)sender);
        }

        /// <summary>
        /// Gère l'affichage du ToolTip sur le bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_MouseHover(object sender, EventArgs e)
        {
            controle.SetToolTip("Modifier", (Button)sender);
        }

        /// <summary>
        /// Gère l'affichage du ToolTip sur le bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_MouseHover(object sender, EventArgs e)
        {
            controle.SetToolTip("Supprimer", (Button)sender);
        }

        /// <summary>
        /// Réinitialise le champ de recherche et affiche tous les enregistrements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            RemplirGridSeries(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
        }

        /// <summary>
        /// Lance la recherche filtrée sur le titre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RemplirGridSeries(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
            }
        }
        
    }
}
