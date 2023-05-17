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
    public partial class FrmJeux : Form
    {
        Controle controle;
        FrmList frmList;
        private string type = "Jeu Video";
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
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Methodes à appliquer lors du chargement du formulaire
        /// </summary>
        private void Init()
        {
            cmbAnnee.SelectedIndex = 1;
            RemplirGridJeux(null, cmbAnnee.Text, null);
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
                imgJeu.ImageLocation = controle.GetLocalImageDirectory() + jeu.img;
            }
        }

        /// <summary>
        /// Gère l'affiche des étoiles qui correspondent à la note
        /// </summary>
        /// <param name="jeu"></param>
        private void LoadImageNote(Jeu jeu)
        {
            int full = imgNote1.Width;
            int semi = imgNote1.Width / 2;
            lblNote.Text = "Note : ";
            switch (jeu.note)
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
        private void RemplirGridJeux(string utilisateur, string annee, string titre)
        {
            dgvJeux.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            lesJeux = controle.GetJeux(utilisateur, annee, titre);
            if (lesJeux.Count != 0)
            {
                grpFiche.Visible = true;
                Sort("dateAjout", SortOrder.None);
            }
            else
            {
                ResetFiche();
                grpFiche.Visible = false;
                dgvJeux.Visible = false;
                lblResultat.Text = "";
            }
        }

        /// <summary>
        /// Gère l'affichage des différents champs de la BDD dans le DataGridView
        /// </summary>
        private void AfficheGrid()
        {
            bdgJeux.DataSource = lesJeux;
            dgvJeux.DataSource = bdgJeux;           
            dgvJeux.Columns["Id"].Visible = false;
            dgvJeux.Columns["utilisateur"].Visible = false;
            dgvJeux.Columns["commentaire"].Visible = false;
            dgvJeux.Columns["plateforme"].Visible = false;
            dgvJeux.Columns["img"].Visible = false;
            dgvJeux.Columns["developpeur"].Visible = false;
            dgvJeux.Columns["genre"].Visible = false;
            dgvJeux.Columns["titre"].HeaderText = "Titre";
            dgvJeux.Columns["tempsJeu"].HeaderText = "Playtime";
            dgvJeux.Columns["note"].HeaderText = "Note";
            dgvJeux.Columns["dateAjout"].HeaderText = "Date";
            dgvJeux.Columns["sortie"].HeaderText = "Sortie";
            dgvJeux.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJeux.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            foreach (DataGridViewColumn col in dgvJeux.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            dgvJeux.Visible = true;
            AfficheNbEnregistrements();
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
                RemplirGridJeux(null, cmbAnnee.Text, txtRecherche.Text);
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
                RemplirGridJeux(radioClemence.Text, cmbAnnee.Text, txtRecherche.Text);
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
                RemplirGridJeux(radioLucas.Text, cmbAnnee.Text, txtRecherche.Text);
            }
        }

        /// <summary>
        /// Permet d'ajouter un nouveau jeu dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter"), sender);
        }

        /// <summary>
        /// Permet de modifier un jeu existant dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
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
                    File.Delete(controle.GetLocalImageDirectory() + jeu.img);
                    SupprJeu(jeu);
                    RemplirGridJeux(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
                }
            }
        }

        private void btnSequel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Jeu jeu = (Jeu)bdgJeux.List[bdgJeux.Position];
            frmList.OpenChildForm(new FrmAjout(controle, type, "Ajouter une suite", jeu), sender);
        }

        /// <summary>
        /// Appelle la methode qui supprime un jeu de la BDD
        /// </summary>
        /// <param name="serie"></param>
        private void SupprJeu(Jeu jeu)
        {
            controle.SupprJeu(jeu);
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
            lblDate.Text = "";
            lblTemps.Text = "";
            lblPlateforme.Text = "";
            imgJeu.Visible = false;
            imgPlateforme.Visible = false;
            imgNote1.Visible = false;
            imgNote2.Visible = false;
            imgNote3.Visible = false;
            imgNote4.Visible = false;
            imgNote5.Visible = false;
            imgNote6.Visible = false;
        }

        /// <summary>
        /// Affiche le nombre d'enregistrements affiché dans le DataGridView
        /// </summary>
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

        /// <summary>
        /// Gère le clic sur un header du DataGridView, déclenche le tri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvJeux_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
                        lesJeux = lesJeux.OrderBy(o => o.titre).ToList();
                    }
                    else
                    {
                        lesJeux = lesJeux.OrderByDescending(o => o.titre).ToList();
                    }
                    AfficheGrid();
                    break;
                case "sortie":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesJeux = lesJeux.OrderBy(o => o.sortie).ToList();
                    }
                    else
                    {
                        lesJeux = lesJeux.OrderByDescending(o => o.sortie).ToList();
                    }
                    AfficheGrid();
                    break;
                case "note":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesJeux = lesJeux.OrderBy(o => o.note).ToList();
                    }
                    else
                    {
                        lesJeux = lesJeux.OrderByDescending(o => o.note).ToList();
                    }
                    AfficheGrid();
                    break;                
                case "dateAjout":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesJeux = lesJeux.OrderBy(o => o.dateAjout).ToList();
                    }
                    else
                    {
                        lesJeux = lesJeux.OrderByDescending(o => o.dateAjout).ToList();
                    }
                    AfficheGrid();
                    break;
                case "tempsJeu":
                    if (sortOrder == SortOrder.Ascending)
                    {
                        lesJeux = lesJeux.OrderBy(o => o.tempsJeu).ToList();
                    }
                    else
                    {
                        lesJeux = lesJeux.OrderByDescending(o => o.tempsJeu).ToList();
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
        private void dgvJeux_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            }
        }

        private void imgJeu_Click(object sender, EventArgs e)
        {
            Process.Start(imgJeu.ImageLocation);
        }

        private void cmbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirGridJeux(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                RemplirGridJeux(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
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
            RemplirGridJeux(grpUtilisateur.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text, cmbAnnee.Text, txtRecherche.Text);
        }

        
    }
}
