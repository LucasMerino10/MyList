
namespace MyList.Vue
{
    partial class FrmJeux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFiche = new System.Windows.Forms.GroupBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDeveloppeur = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPlateforme = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTemps = new System.Windows.Forms.Label();
            this.lblSortie = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpUtilisateur = new System.Windows.Forms.GroupBox();
            this.radioLucas = new System.Windows.Forms.RadioButton();
            this.radioClemence = new System.Windows.Forms.RadioButton();
            this.radioTous = new System.Windows.Forms.RadioButton();
            this.dgvJeux = new System.Windows.Forms.DataGridView();
            this.lblResultat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnnee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSequel = new System.Windows.Forms.Button();
            this.imgNote6 = new System.Windows.Forms.PictureBox();
            this.imgNote2 = new System.Windows.Forms.PictureBox();
            this.imgNote5 = new System.Windows.Forms.PictureBox();
            this.imgNote4 = new System.Windows.Forms.PictureBox();
            this.imgNote3 = new System.Windows.Forms.PictureBox();
            this.imgNote1 = new System.Windows.Forms.PictureBox();
            this.imgPlateforme = new System.Windows.Forms.PictureBox();
            this.imgJeu = new System.Windows.Forms.PictureBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.grpFiche.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpUtilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlateforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJeu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiche
            // 
            this.grpFiche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiche.Controls.Add(this.lblGenre);
            this.grpFiche.Controls.Add(this.lblDeveloppeur);
            this.grpFiche.Controls.Add(this.imgNote6);
            this.grpFiche.Controls.Add(this.imgNote2);
            this.grpFiche.Controls.Add(this.imgNote5);
            this.grpFiche.Controls.Add(this.imgNote4);
            this.grpFiche.Controls.Add(this.imgNote3);
            this.grpFiche.Controls.Add(this.imgNote1);
            this.grpFiche.Controls.Add(this.lblCommentaire);
            this.grpFiche.Controls.Add(this.panel1);
            this.grpFiche.Controls.Add(this.imgPlateforme);
            this.grpFiche.Controls.Add(this.lblPlateforme);
            this.grpFiche.Controls.Add(this.lblDate);
            this.grpFiche.Controls.Add(this.lblTemps);
            this.grpFiche.Controls.Add(this.lblSortie);
            this.grpFiche.Controls.Add(this.lblNote);
            this.grpFiche.Controls.Add(this.imgJeu);
            this.grpFiche.Location = new System.Drawing.Point(692, 28);
            this.grpFiche.Name = "grpFiche";
            this.grpFiche.Size = new System.Drawing.Size(1184, 692);
            this.grpFiche.TabIndex = 23;
            this.grpFiche.TabStop = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(588, 384);
            this.lblGenre.MaximumSize = new System.Drawing.Size(549, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(91, 21);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.Text = "Genre(s) :";
            // 
            // lblDeveloppeur
            // 
            this.lblDeveloppeur.AutoSize = true;
            this.lblDeveloppeur.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloppeur.Location = new System.Drawing.Point(588, 304);
            this.lblDeveloppeur.MaximumSize = new System.Drawing.Size(549, 0);
            this.lblDeveloppeur.Name = "lblDeveloppeur";
            this.lblDeveloppeur.Size = new System.Drawing.Size(122, 21);
            this.lblDeveloppeur.TabIndex = 24;
            this.lblDeveloppeur.Text = "Développeur :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.Location = new System.Drawing.Point(588, 544);
            this.lblCommentaire.MaximumSize = new System.Drawing.Size(549, 0);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(116, 21);
            this.lblCommentaire.TabIndex = 12;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Location = new System.Drawing.Point(592, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 84);
            this.panel1.TabIndex = 11;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitre.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(20, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(510, 84);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlateforme
            // 
            this.lblPlateforme.AutoSize = true;
            this.lblPlateforme.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateforme.Location = new System.Drawing.Point(946, 144);
            this.lblPlateforme.Name = "lblPlateforme";
            this.lblPlateforme.Size = new System.Drawing.Size(106, 21);
            this.lblPlateforme.TabIndex = 9;
            this.lblPlateforme.Text = "Plateforme :";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(588, 646);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 21);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Ajouté le";
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemps.Location = new System.Drawing.Point(588, 224);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(215, 21);
            this.lblTemps.TabIndex = 5;
            this.lblTemps.Text = "Temps de jeu (estimation)";
            // 
            // lblSortie
            // 
            this.lblSortie.AutoSize = true;
            this.lblSortie.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortie.Location = new System.Drawing.Point(588, 144);
            this.lblSortie.Name = "lblSortie";
            this.lblSortie.Size = new System.Drawing.Size(135, 21);
            this.lblSortie.TabIndex = 3;
            this.lblSortie.Text = "Année de sortie";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(588, 464);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(58, 21);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Note :";
            // 
            // grpUtilisateur
            // 
            this.grpUtilisateur.Controls.Add(this.radioLucas);
            this.grpUtilisateur.Controls.Add(this.radioClemence);
            this.grpUtilisateur.Controls.Add(this.radioTous);
            this.grpUtilisateur.Location = new System.Drawing.Point(22, 28);
            this.grpUtilisateur.Name = "grpUtilisateur";
            this.grpUtilisateur.Size = new System.Drawing.Size(208, 125);
            this.grpUtilisateur.TabIndex = 19;
            this.grpUtilisateur.TabStop = false;
            this.grpUtilisateur.Text = "Selection de l\'utilisateur";
            // 
            // radioLucas
            // 
            this.radioLucas.AutoSize = true;
            this.radioLucas.Location = new System.Drawing.Point(6, 85);
            this.radioLucas.Name = "radioLucas";
            this.radioLucas.Size = new System.Drawing.Size(77, 24);
            this.radioLucas.TabIndex = 2;
            this.radioLucas.Text = "Lucas";
            this.radioLucas.UseVisualStyleBackColor = true;
            this.radioLucas.CheckedChanged += new System.EventHandler(this.radioLucas_CheckedChanged);
            // 
            // radioClemence
            // 
            this.radioClemence.AutoSize = true;
            this.radioClemence.Location = new System.Drawing.Point(6, 55);
            this.radioClemence.Name = "radioClemence";
            this.radioClemence.Size = new System.Drawing.Size(70, 24);
            this.radioClemence.TabIndex = 1;
            this.radioClemence.Text = "Clem";
            this.radioClemence.UseVisualStyleBackColor = true;
            this.radioClemence.CheckedChanged += new System.EventHandler(this.radioClemence_CheckedChanged);
            // 
            // radioTous
            // 
            this.radioTous.AutoSize = true;
            this.radioTous.Checked = true;
            this.radioTous.Location = new System.Drawing.Point(6, 25);
            this.radioTous.Name = "radioTous";
            this.radioTous.Size = new System.Drawing.Size(69, 24);
            this.radioTous.TabIndex = 0;
            this.radioTous.TabStop = true;
            this.radioTous.Text = "Tous";
            this.radioTous.UseVisualStyleBackColor = true;
            this.radioTous.CheckedChanged += new System.EventHandler(this.radioTous_CheckedChanged);
            // 
            // dgvJeux
            // 
            this.dgvJeux.AllowUserToAddRows = false;
            this.dgvJeux.AllowUserToDeleteRows = false;
            this.dgvJeux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJeux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJeux.Location = new System.Drawing.Point(22, 206);
            this.dgvJeux.MultiSelect = false;
            this.dgvJeux.Name = "dgvJeux";
            this.dgvJeux.ReadOnly = true;
            this.dgvJeux.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvJeux.RowTemplate.Height = 28;
            this.dgvJeux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJeux.Size = new System.Drawing.Size(650, 448);
            this.dgvJeux.TabIndex = 18;
            this.dgvJeux.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvJeux_CellFormatting);
            this.dgvJeux.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJeux_ColumnHeaderMouseClick);
            this.dgvJeux.SelectionChanged += new System.EventHandler(this.dgvJeux_SelectionChanged);
            // 
            // lblResultat
            // 
            this.lblResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(454, 668);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(220, 22);
            this.lblResultat.TabIndex = 25;
            this.lblResultat.Text = "Nombre d\'enregistrements";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Année : ";
            // 
            // cmbAnnee
            // 
            this.cmbAnnee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnnee.FormattingEnabled = true;
            this.cmbAnnee.Items.AddRange(new object[] {
            "2022",
            "2023",
            "All"});
            this.cmbAnnee.Location = new System.Drawing.Point(552, 170);
            this.cmbAnnee.Name = "cmbAnnee";
            this.cmbAnnee.Size = new System.Drawing.Size(120, 28);
            this.cmbAnnee.TabIndex = 29;
            this.cmbAnnee.SelectedIndexChanged += new System.EventHandler(this.cmbAnnee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Titre : ";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(92, 170);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(262, 26);
            this.txtRecherche.TabIndex = 34;
            this.txtRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecherche_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::MyList.Properties.Resources._return;
            this.btnReset.Location = new System.Drawing.Point(360, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 44);
            this.btnReset.TabIndex = 35;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSequel
            // 
            this.btnSequel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSequel.FlatAppearance.BorderSize = 0;
            this.btnSequel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSequel.Image = global::MyList.Properties.Resources.copy;
            this.btnSequel.Location = new System.Drawing.Point(262, 668);
            this.btnSequel.Name = "btnSequel";
            this.btnSequel.Size = new System.Drawing.Size(64, 64);
            this.btnSequel.TabIndex = 32;
            this.btnSequel.UseVisualStyleBackColor = true;
            this.btnSequel.Click += new System.EventHandler(this.btnSequel_Click);
            // 
            // imgNote6
            // 
            this.imgNote6.Image = global::MyList.Properties.Resources._002_favorite_1;
            this.imgNote6.Location = new System.Drawing.Point(833, 448);
            this.imgNote6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote6.Name = "imgNote6";
            this.imgNote6.Size = new System.Drawing.Size(36, 37);
            this.imgNote6.TabIndex = 23;
            this.imgNote6.TabStop = false;
            // 
            // imgNote2
            // 
            this.imgNote2.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote2.Location = new System.Drawing.Point(689, 448);
            this.imgNote2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote2.Name = "imgNote2";
            this.imgNote2.Size = new System.Drawing.Size(36, 37);
            this.imgNote2.TabIndex = 22;
            this.imgNote2.TabStop = false;
            // 
            // imgNote5
            // 
            this.imgNote5.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote5.Location = new System.Drawing.Point(797, 448);
            this.imgNote5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote5.Name = "imgNote5";
            this.imgNote5.Size = new System.Drawing.Size(36, 37);
            this.imgNote5.TabIndex = 21;
            this.imgNote5.TabStop = false;
            // 
            // imgNote4
            // 
            this.imgNote4.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote4.Location = new System.Drawing.Point(761, 448);
            this.imgNote4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote4.Name = "imgNote4";
            this.imgNote4.Size = new System.Drawing.Size(36, 37);
            this.imgNote4.TabIndex = 20;
            this.imgNote4.TabStop = false;
            // 
            // imgNote3
            // 
            this.imgNote3.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote3.Location = new System.Drawing.Point(725, 448);
            this.imgNote3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote3.Name = "imgNote3";
            this.imgNote3.Size = new System.Drawing.Size(36, 37);
            this.imgNote3.TabIndex = 19;
            this.imgNote3.TabStop = false;
            // 
            // imgNote1
            // 
            this.imgNote1.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote1.Location = new System.Drawing.Point(653, 448);
            this.imgNote1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote1.Name = "imgNote1";
            this.imgNote1.Size = new System.Drawing.Size(36, 37);
            this.imgNote1.TabIndex = 18;
            this.imgNote1.TabStop = false;
            // 
            // imgPlateforme
            // 
            this.imgPlateforme.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgPlateforme.Location = new System.Drawing.Point(1056, 124);
            this.imgPlateforme.Name = "imgPlateforme";
            this.imgPlateforme.Size = new System.Drawing.Size(64, 65);
            this.imgPlateforme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlateforme.TabIndex = 10;
            this.imgPlateforme.TabStop = false;
            // 
            // imgJeu
            // 
            this.imgJeu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgJeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgJeu.Location = new System.Drawing.Point(15, 25);
            this.imgJeu.Name = "imgJeu";
            this.imgJeu.Size = new System.Drawing.Size(538, 642);
            this.imgJeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgJeu.TabIndex = 0;
            this.imgJeu.TabStop = false;
            this.imgJeu.Click += new System.EventHandler(this.imgJeu_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Image = global::MyList.Properties.Resources.delete;
            this.btnSupprimer.Location = new System.Drawing.Point(182, 668);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(64, 64);
            this.btnSupprimer.TabIndex = 22;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            this.btnSupprimer.MouseHover += new System.EventHandler(this.btnSupprimer_MouseHover);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Image = global::MyList.Properties.Resources.edit;
            this.btnModifier.Location = new System.Drawing.Point(102, 668);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(64, 64);
            this.btnModifier.TabIndex = 21;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.btnModifier.MouseHover += new System.EventHandler(this.btnModifier_MouseHover);
            // 
            // btnAjout
            // 
            this.btnAjout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjout.FlatAppearance.BorderSize = 0;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.Image = global::MyList.Properties.Resources.plus;
            this.btnAjout.Location = new System.Drawing.Point(22, 668);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(64, 64);
            this.btnAjout.TabIndex = 20;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            this.btnAjout.MouseHover += new System.EventHandler(this.btnAjout_MouseHover);
            // 
            // FrmJeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 744);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSequel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnnee);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.grpFiche);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.grpUtilisateur);
            this.Controls.Add(this.dgvJeux);
            this.Name = "FrmJeux";
            this.Text = "JEUX VIDEO";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmJeux_Load);
            this.grpFiche.ResumeLayout(false);
            this.grpFiche.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpUtilisateur.ResumeLayout(false);
            this.grpUtilisateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJeux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlateforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiche;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox imgPlateforme;
        private System.Windows.Forms.Label lblPlateforme;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.Label lblSortie;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.PictureBox imgJeu;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.GroupBox grpUtilisateur;
        private System.Windows.Forms.RadioButton radioLucas;
        private System.Windows.Forms.RadioButton radioClemence;
        private System.Windows.Forms.RadioButton radioTous;
        private System.Windows.Forms.DataGridView dgvJeux;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.PictureBox imgNote6;
        private System.Windows.Forms.PictureBox imgNote2;
        private System.Windows.Forms.PictureBox imgNote5;
        private System.Windows.Forms.PictureBox imgNote4;
        private System.Windows.Forms.PictureBox imgNote3;
        private System.Windows.Forms.PictureBox imgNote1;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDeveloppeur;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnnee;
        private System.Windows.Forms.Button btnSequel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnReset;
    }
}