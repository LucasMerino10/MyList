using MyList.Controleur;
using MyList.Modele;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyList.Vue
{
    public partial class FrmFilms : Form
    {
        Controle controle;
        FrmList frmList;
        private string type = "Film";
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
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Methodes à appliquer lors du chargement du formulaire
        /// </summary>
        private void Init()
        {
            LoadTheme();
            cmbAnnee.SelectedIndex = 1;
            RemplirGridFilms(null, cmbAnnee.Text, null);
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
        /// Récupère l'image correspondant au film sélectionné
        /// </summary>
        private void LoadImage(Film film)
        {
            imgFilm.Visible = true;
            imgFilm.ImageLocation = controle.GetLocalImageDirectory() + film.img;
        }

        private void LoadImageNote(Film film)
        {
            int full = imgNote1.Width;
            int semi = imgNote1.Width / 2;
            lblNote.Text = "Note : ";
            switch (film.note)
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
        private void RemplirGridFilms(string utilisateur, string annee, string titre)
        {       
            lesFilms = controle.GetFilms(utilisateur, annee, titre);
            if (lesFilms.Count != 0)
            {
                grpFiche.Visible = true;
                Sort("dateAjout", SortOrder.None);
            }
            else
            {
                ResetFiche();
                grpFiche.Visible = false;
                dgvFilms.Visible = false;
                lblResultat.Text = "";
            }
        }

        /// <summary>
        /// Gère l'affichage des différents champs de la BDD dans le DataGridView
        /// </summary>
        private void AfficheGrid()
        {
            bdgFilms.DataSource = lesFilms;
            dgvFilms.DataSource = bdgFilms;
            dgvFilms.Columns["Id"].Visible = false;
            dgvFilms.Columns["utilisateur"].Visible = false;
            dgvFilms.Columns["duree"].Visible = false;
            dgvFilms.Columns["plateforme"].Visible = false;
            dgvFilms.Columns["commentaire"].Visible = false;
            dgvFilms.Columns["casting"].Visible = false;
            dgvFilms.Columns["img"].Visible = false;
            dgvFilms.Columns["realisateur"].Visible = false;
            dgvFilms.Columns["genre"].Visible = false;
            dgvFilms.Columns["imdb"].Visible = false;
            dgvFilms.Columns["titre"].HeaderText = "Titre";            
            dgvFilms.Columns["sortie"].HeaderText = "Sortie";
            dgvFilms.Columns["note"].HeaderText = "Note";
            dgvFilms.Columns["dateAjout"].HeaderText = "Date";
            dgvFilms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;            
            foreach (DataGridViewColumn col in dgvFilms.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            dgvFilms.Visible = true;           
            AfficheNbEnregistrements();
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
            lblRealisateur.Text = film.GetRealisateur();
            lblGenre.Text = film.GetGenre();
            if(film.imdb == null || film.imdb == "")
            {
                lblImdb.Visible = false;
            }
            else
            {
                lblImdb.Visible = true;
            }
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
                RemplirGridFilms(null, cmbAnnee.Text, txtRecherche.Text);
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
                RemplirGridFilms(radioClemence.Text, cmbAnnee.Text, txtRecherche.Text);
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
                RemplirGridFilms(radioLucas.Text, cmbAnnee.Text, txtRecherche.Text);
            }
        }     

        /// <summary>
        /// Permet d'ajouter un film dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter"), sender);
        }

        /// <summary>
        /// Permet de modifier un film existant dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Film film = (Film)bdgFilms.List[bdgFilms.Position];
            frmList.OpenChildForm(new FrmAjout(controle, type, "Modifier", film), sender);
        }

        /// <summary>
        /// Permet d'ajouter une nouvel enregistrement en reprenant les bases de l'enregistrement séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSequel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Film film = (Film)bdgFilms.List[bdgFilms.Position];
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter une suite", film), sender);
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
                    File.Delete(controle.GetLocalImageDirectory() + film.img);
                    SupprJeu(film);
                    RemplirGridFilms(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
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

        /// <summary>
        /// Vide les informations de la fiche
        /// </summary>
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
            lblImdb.Visible = false;
        }

        /// <summary>
        /// Affiche le nombre d'enregistrements affiché dans le DataGridView
        /// </summary>
        private void AfficheNbEnregistrements()
        {
            if (dgvFilms.RowCount > 1)
            {
                lblResultat.Text = dgvFilms.RowCount.ToString() + " films enregistrés";
            }
            else
            {
                lblResultat.Text = dgvFilms.RowCount.ToString() + " film enregistré";
            }
        }

        /// <summary>
        /// Gère le clic sur un header du DataGridView, déclenche le tri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFilms_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            SortOrder so = SortOrder.None;
            if(grid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
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
                    if(sortOrder == SortOrder.Ascending)
                    {
                        lesFilms = lesFilms.OrderBy(o => o.titre).ToList();
                    }
                    else
                    {
                        lesFilms = lesFilms.OrderByDescending(o => o.titre).ToList();
                    }
                    AfficheGrid();
                    break;
                case "note":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesFilms = lesFilms.OrderBy(o => o.note).ToList();
                    }
                    else
                    {
                        lesFilms = lesFilms.OrderByDescending(o => o.note).ToList();
                    }
                    AfficheGrid();
                    break;
                case "sortie":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesFilms = lesFilms.OrderBy(o => o.sortie).ToList();
                    }
                    else
                    {
                        lesFilms = lesFilms.OrderByDescending(o => o.sortie).ToList();
                    }
                    AfficheGrid();
                    break;             
                case "dateAjout":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesFilms = lesFilms.OrderBy(o => o.dateAjout).ToList();
                    }
                    else
                    {
                        lesFilms = lesFilms.OrderByDescending(o => o.dateAjout).ToList();
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
        private void dgvFilms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
            Film film = (Film)bdgFilms.List[bdgFilms.Position];
            try
            {
                Process.Start(film.imdb);
            }catch(Exception)
            {
                MessageBox.Show("Oups! Mauvais lien renseigné.", "Erreur");
            }
        }

        private void imgFilm_Click(object sender, EventArgs e)
        {
            Process.Start(imgFilm.ImageLocation);
        }

        private void cmbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirGridFilms(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
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
        /// Lance la recherche filtrée sur le titre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                RemplirGridFilms(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
            }
        }

        /// <summary>
        /// Réinitialise le champ de recherche et affiche tous les enregistrements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            RemplirGridFilms(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
        }

        
    }
}
