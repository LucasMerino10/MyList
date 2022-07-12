
namespace MyList.Vue
{
    partial class FrmAjout
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
            this.btnValider = new System.Windows.Forms.Button();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRealisateur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRealisateurInfo = new System.Windows.Forms.Label();
            this.cboUtilisateur = new System.Windows.Forms.ComboBox();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.txtBoxCasting = new System.Windows.Forms.TextBox();
            this.lblCastingInfo = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.cboPlateforme = new System.Windows.Forms.ComboBox();
            this.cboNote = new System.Windows.Forms.ComboBox();
            this.txtBoxCommentaire = new System.Windows.Forms.TextBox();
            this.txtBoxSpe = new System.Windows.Forms.TextBox();
            this.txtBoxSortie = new System.Windows.Forms.TextBox();
            this.txtBoxTitre = new System.Windows.Forms.TextBox();
            this.lblSpecialInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioJeu = new System.Windows.Forms.RadioButton();
            this.radioSérie = new System.Windows.Forms.RadioButton();
            this.radioFilm = new System.Windows.Forms.RadioButton();
            this.grpFiche = new System.Windows.Forms.GroupBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRealisateurFiche = new System.Windows.Forms.Label();
            this.lblSpecialFiche = new System.Windows.Forms.Label();
            this.imgNote6 = new System.Windows.Forms.PictureBox();
            this.imgNote2 = new System.Windows.Forms.PictureBox();
            this.imgNote5 = new System.Windows.Forms.PictureBox();
            this.imgNote4 = new System.Windows.Forms.PictureBox();
            this.imgNote3 = new System.Windows.Forms.PictureBox();
            this.imgNote1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.imgPlateforme = new System.Windows.Forms.PictureBox();
            this.lblPlateforme = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblCastingFiche = new System.Windows.Forms.Label();
            this.lblSortie = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imgFiche = new System.Windows.Forms.PictureBox();
            this.grpType.SuspendLayout();
            this.grpFiche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlateforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiche)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnValider.Location = new System.Drawing.Point(16, 670);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 37);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // grpType
            // 
            this.grpType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpType.Controls.Add(this.txtGenre);
            this.grpType.Controls.Add(this.txtRealisateur);
            this.grpType.Controls.Add(this.label8);
            this.grpType.Controls.Add(this.lblRealisateurInfo);
            this.grpType.Controls.Add(this.cboUtilisateur);
            this.grpType.Controls.Add(this.lblUtilisateur);
            this.grpType.Controls.Add(this.txtBoxCasting);
            this.grpType.Controls.Add(this.lblCastingInfo);
            this.grpType.Controls.Add(this.lblImage);
            this.grpType.Controls.Add(this.btnImage);
            this.grpType.Controls.Add(this.cboPlateforme);
            this.grpType.Controls.Add(this.cboNote);
            this.grpType.Controls.Add(this.txtBoxCommentaire);
            this.grpType.Controls.Add(this.txtBoxSpe);
            this.grpType.Controls.Add(this.txtBoxSortie);
            this.grpType.Controls.Add(this.txtBoxTitre);
            this.grpType.Controls.Add(this.lblSpecialInfo);
            this.grpType.Controls.Add(this.label3);
            this.grpType.Controls.Add(this.label4);
            this.grpType.Controls.Add(this.label5);
            this.grpType.Controls.Add(this.label2);
            this.grpType.Controls.Add(this.label1);
            this.grpType.Controls.Add(this.radioJeu);
            this.grpType.Controls.Add(this.radioSérie);
            this.grpType.Controls.Add(this.btnValider);
            this.grpType.Controls.Add(this.radioFilm);
            this.grpType.Location = new System.Drawing.Point(16, 28);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(458, 713);
            this.grpType.TabIndex = 1;
            this.grpType.TabStop = false;
            this.grpType.Text = "Informations";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(159, 233);
            this.txtGenre.MaxLength = 50;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(280, 26);
            this.txtGenre.TabIndex = 6;
            this.txtGenre.TextChanged += new System.EventHandler(this.txtGenre_TextChanged);
            // 
            // txtRealisateur
            // 
            this.txtRealisateur.Location = new System.Drawing.Point(159, 183);
            this.txtRealisateur.MaxLength = 50;
            this.txtRealisateur.Name = "txtRealisateur";
            this.txtRealisateur.Size = new System.Drawing.Size(280, 26);
            this.txtRealisateur.TabIndex = 5;
            this.txtRealisateur.TextChanged += new System.EventHandler(this.txtRealisateur_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Genre(s) :";
            // 
            // lblRealisateurInfo
            // 
            this.lblRealisateurInfo.AutoSize = true;
            this.lblRealisateurInfo.Location = new System.Drawing.Point(15, 186);
            this.lblRealisateurInfo.Name = "lblRealisateurInfo";
            this.lblRealisateurInfo.Size = new System.Drawing.Size(104, 20);
            this.lblRealisateurInfo.TabIndex = 21;
            this.lblRealisateurInfo.Text = "Réalisateur* :";
            // 
            // cboUtilisateur
            // 
            this.cboUtilisateur.FormattingEnabled = true;
            this.cboUtilisateur.Items.AddRange(new object[] {
            "Clem",
            "Lucas"});
            this.cboUtilisateur.Location = new System.Drawing.Point(159, 83);
            this.cboUtilisateur.Name = "cboUtilisateur";
            this.cboUtilisateur.Size = new System.Drawing.Size(121, 28);
            this.cboUtilisateur.TabIndex = 3;
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Location = new System.Drawing.Point(15, 86);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(94, 20);
            this.lblUtilisateur.TabIndex = 19;
            this.lblUtilisateur.Text = "Utilisateur* :";
            // 
            // txtBoxCasting
            // 
            this.txtBoxCasting.Location = new System.Drawing.Point(159, 433);
            this.txtBoxCasting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCasting.MaxLength = 120;
            this.txtBoxCasting.Name = "txtBoxCasting";
            this.txtBoxCasting.Size = new System.Drawing.Size(280, 26);
            this.txtBoxCasting.TabIndex = 10;
            this.txtBoxCasting.TextChanged += new System.EventHandler(this.txtBoxCasting_TextChanged);
            // 
            // lblCastingInfo
            // 
            this.lblCastingInfo.AutoSize = true;
            this.lblCastingInfo.Location = new System.Drawing.Point(15, 436);
            this.lblCastingInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCastingInfo.Name = "lblCastingInfo";
            this.lblCastingInfo.Size = new System.Drawing.Size(75, 20);
            this.lblCastingInfo.TabIndex = 17;
            this.lblCastingInfo.Text = "Casting  :";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(155, 540);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(0, 20);
            this.lblImage.TabIndex = 16;
            // 
            // btnImage
            // 
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Location = new System.Drawing.Point(16, 536);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(126, 35);
            this.btnImage.TabIndex = 12;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // cboPlateforme
            // 
            this.cboPlateforme.FormattingEnabled = true;
            this.cboPlateforme.Location = new System.Drawing.Point(159, 383);
            this.cboPlateforme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPlateforme.Name = "cboPlateforme";
            this.cboPlateforme.Size = new System.Drawing.Size(180, 28);
            this.cboPlateforme.TabIndex = 9;
            this.cboPlateforme.SelectedIndexChanged += new System.EventHandler(this.cboPlateforme_SelectedIndexChanged);
            // 
            // cboNote
            // 
            this.cboNote.FormattingEnabled = true;
            this.cboNote.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboNote.Location = new System.Drawing.Point(159, 480);
            this.cboNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNote.Name = "cboNote";
            this.cboNote.Size = new System.Drawing.Size(180, 28);
            this.cboNote.TabIndex = 11;
            this.cboNote.SelectedIndexChanged += new System.EventHandler(this.cboNote_SelectedIndexChanged);
            // 
            // txtBoxCommentaire
            // 
            this.txtBoxCommentaire.AcceptsReturn = true;
            this.txtBoxCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCommentaire.Location = new System.Drawing.Point(159, 586);
            this.txtBoxCommentaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCommentaire.MaxLength = 540;
            this.txtBoxCommentaire.Multiline = true;
            this.txtBoxCommentaire.Name = "txtBoxCommentaire";
            this.txtBoxCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCommentaire.Size = new System.Drawing.Size(280, 76);
            this.txtBoxCommentaire.TabIndex = 13;
            this.txtBoxCommentaire.TextChanged += new System.EventHandler(this.txtBoxCommentaire_TextChanged);
            // 
            // txtBoxSpe
            // 
            this.txtBoxSpe.Location = new System.Drawing.Point(159, 333);
            this.txtBoxSpe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSpe.MaxLength = 4;
            this.txtBoxSpe.Name = "txtBoxSpe";
            this.txtBoxSpe.Size = new System.Drawing.Size(180, 26);
            this.txtBoxSpe.TabIndex = 8;
            this.txtBoxSpe.TextChanged += new System.EventHandler(this.txtBoxSpe_TextChanged);
            // 
            // txtBoxSortie
            // 
            this.txtBoxSortie.Location = new System.Drawing.Point(159, 283);
            this.txtBoxSortie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSortie.MaxLength = 4;
            this.txtBoxSortie.Name = "txtBoxSortie";
            this.txtBoxSortie.Size = new System.Drawing.Size(180, 26);
            this.txtBoxSortie.TabIndex = 7;
            this.txtBoxSortie.TextChanged += new System.EventHandler(this.txtBoxSortie_TextChanged);
            // 
            // txtBoxTitre
            // 
            this.txtBoxTitre.Location = new System.Drawing.Point(159, 133);
            this.txtBoxTitre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxTitre.MaxLength = 70;
            this.txtBoxTitre.Name = "txtBoxTitre";
            this.txtBoxTitre.Size = new System.Drawing.Size(280, 26);
            this.txtBoxTitre.TabIndex = 4;
            this.txtBoxTitre.TextChanged += new System.EventHandler(this.txtBoxTitre_TextChanged);
            // 
            // lblSpecialInfo
            // 
            this.lblSpecialInfo.AutoSize = true;
            this.lblSpecialInfo.Location = new System.Drawing.Point(15, 336);
            this.lblSpecialInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialInfo.Name = "lblSpecialInfo";
            this.lblSpecialInfo.Size = new System.Drawing.Size(76, 20);
            this.lblSpecialInfo.TabIndex = 8;
            this.lblSpecialInfo.Text = "Attr. Spé.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 386);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plateforme* :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Note* :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 586);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Commentaire  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Année de sortie* :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titre* :";
            // 
            // radioJeu
            // 
            this.radioJeu.AutoSize = true;
            this.radioJeu.Location = new System.Drawing.Point(296, 38);
            this.radioJeu.Name = "radioJeu";
            this.radioJeu.Size = new System.Drawing.Size(105, 24);
            this.radioJeu.TabIndex = 2;
            this.radioJeu.TabStop = true;
            this.radioJeu.Text = "Jeu Video";
            this.radioJeu.UseVisualStyleBackColor = true;
            this.radioJeu.CheckedChanged += new System.EventHandler(this.radioJeu_CheckedChanged);
            // 
            // radioSérie
            // 
            this.radioSérie.AutoSize = true;
            this.radioSérie.Location = new System.Drawing.Point(156, 38);
            this.radioSérie.Name = "radioSérie";
            this.radioSérie.Size = new System.Drawing.Size(71, 24);
            this.radioSérie.TabIndex = 1;
            this.radioSérie.TabStop = true;
            this.radioSérie.Text = "Série";
            this.radioSérie.UseVisualStyleBackColor = true;
            this.radioSérie.CheckedChanged += new System.EventHandler(this.radioSérie_CheckedChanged);
            // 
            // radioFilm
            // 
            this.radioFilm.AutoSize = true;
            this.radioFilm.Location = new System.Drawing.Point(16, 38);
            this.radioFilm.Name = "radioFilm";
            this.radioFilm.Size = new System.Drawing.Size(63, 24);
            this.radioFilm.TabIndex = 0;
            this.radioFilm.TabStop = true;
            this.radioFilm.Text = "Film";
            this.radioFilm.UseVisualStyleBackColor = true;
            this.radioFilm.CheckedChanged += new System.EventHandler(this.radioFilm_CheckedChanged);
            // 
            // grpFiche
            // 
            this.grpFiche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiche.Controls.Add(this.lblGenre);
            this.grpFiche.Controls.Add(this.lblRealisateurFiche);
            this.grpFiche.Controls.Add(this.lblSpecialFiche);
            this.grpFiche.Controls.Add(this.imgNote6);
            this.grpFiche.Controls.Add(this.imgNote2);
            this.grpFiche.Controls.Add(this.imgNote5);
            this.grpFiche.Controls.Add(this.imgNote4);
            this.grpFiche.Controls.Add(this.imgNote3);
            this.grpFiche.Controls.Add(this.imgNote1);
            this.grpFiche.Controls.Add(this.panel1);
            this.grpFiche.Controls.Add(this.imgPlateforme);
            this.grpFiche.Controls.Add(this.lblPlateforme);
            this.grpFiche.Controls.Add(this.lblCommentaire);
            this.grpFiche.Controls.Add(this.lblCastingFiche);
            this.grpFiche.Controls.Add(this.lblSortie);
            this.grpFiche.Controls.Add(this.label7);
            this.grpFiche.Controls.Add(this.imgFiche);
            this.grpFiche.Location = new System.Drawing.Point(490, 28);
            this.grpFiche.Name = "grpFiche";
            this.grpFiche.Size = new System.Drawing.Size(1184, 713);
            this.grpFiche.TabIndex = 2;
            this.grpFiche.TabStop = false;
            this.grpFiche.Text = "Prévisualisation";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(593, 396);
            this.lblGenre.MaximumSize = new System.Drawing.Size(549, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(91, 21);
            this.lblGenre.TabIndex = 45;
            this.lblGenre.Text = "Genre(s) :";
            // 
            // lblRealisateurFiche
            // 
            this.lblRealisateurFiche.AutoSize = true;
            this.lblRealisateurFiche.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealisateurFiche.Location = new System.Drawing.Point(593, 236);
            this.lblRealisateurFiche.MaximumSize = new System.Drawing.Size(549, 0);
            this.lblRealisateurFiche.Name = "lblRealisateurFiche";
            this.lblRealisateurFiche.Size = new System.Drawing.Size(111, 21);
            this.lblRealisateurFiche.TabIndex = 44;
            this.lblRealisateurFiche.Text = "Réalisateur :";
            // 
            // lblSpecialFiche
            // 
            this.lblSpecialFiche.AutoSize = true;
            this.lblSpecialFiche.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialFiche.Location = new System.Drawing.Point(593, 316);
            this.lblSpecialFiche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialFiche.Name = "lblSpecialFiche";
            this.lblSpecialFiche.Size = new System.Drawing.Size(127, 21);
            this.lblSpecialFiche.TabIndex = 43;
            this.lblSpecialFiche.Text = "Attribut special";
            // 
            // imgNote6
            // 
            this.imgNote6.Image = global::MyList.Properties.Resources._002_favorite_1;
            this.imgNote6.Location = new System.Drawing.Point(838, 459);
            this.imgNote6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote6.Name = "imgNote6";
            this.imgNote6.Size = new System.Drawing.Size(36, 37);
            this.imgNote6.TabIndex = 41;
            this.imgNote6.TabStop = false;
            this.imgNote6.Visible = false;
            // 
            // imgNote2
            // 
            this.imgNote2.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote2.Location = new System.Drawing.Point(694, 459);
            this.imgNote2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote2.Name = "imgNote2";
            this.imgNote2.Size = new System.Drawing.Size(36, 37);
            this.imgNote2.TabIndex = 40;
            this.imgNote2.TabStop = false;
            this.imgNote2.Visible = false;
            // 
            // imgNote5
            // 
            this.imgNote5.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote5.Location = new System.Drawing.Point(802, 459);
            this.imgNote5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote5.Name = "imgNote5";
            this.imgNote5.Size = new System.Drawing.Size(36, 37);
            this.imgNote5.TabIndex = 39;
            this.imgNote5.TabStop = false;
            this.imgNote5.Visible = false;
            // 
            // imgNote4
            // 
            this.imgNote4.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote4.Location = new System.Drawing.Point(766, 459);
            this.imgNote4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote4.Name = "imgNote4";
            this.imgNote4.Size = new System.Drawing.Size(36, 37);
            this.imgNote4.TabIndex = 38;
            this.imgNote4.TabStop = false;
            this.imgNote4.Visible = false;
            // 
            // imgNote3
            // 
            this.imgNote3.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote3.Location = new System.Drawing.Point(730, 459);
            this.imgNote3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote3.Name = "imgNote3";
            this.imgNote3.Size = new System.Drawing.Size(36, 37);
            this.imgNote3.TabIndex = 37;
            this.imgNote3.TabStop = false;
            this.imgNote3.Visible = false;
            // 
            // imgNote1
            // 
            this.imgNote1.Image = global::MyList.Properties.Resources._001_favorite;
            this.imgNote1.Location = new System.Drawing.Point(658, 459);
            this.imgNote1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgNote1.Name = "imgNote1";
            this.imgNote1.Size = new System.Drawing.Size(36, 37);
            this.imgNote1.TabIndex = 36;
            this.imgNote1.TabStop = false;
            this.imgNote1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Location = new System.Drawing.Point(597, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 103);
            this.panel1.TabIndex = 35;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitre.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(20, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(510, 103);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgPlateforme
            // 
            this.imgPlateforme.Location = new System.Drawing.Point(1063, 135);
            this.imgPlateforme.Name = "imgPlateforme";
            this.imgPlateforme.Size = new System.Drawing.Size(64, 65);
            this.imgPlateforme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlateforme.TabIndex = 34;
            this.imgPlateforme.TabStop = false;
            // 
            // lblPlateforme
            // 
            this.lblPlateforme.AutoSize = true;
            this.lblPlateforme.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateforme.Location = new System.Drawing.Point(951, 155);
            this.lblPlateforme.Name = "lblPlateforme";
            this.lblPlateforme.Size = new System.Drawing.Size(106, 21);
            this.lblPlateforme.TabIndex = 33;
            this.lblPlateforme.Text = "Plateforme :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.Location = new System.Drawing.Point(593, 635);
            this.lblCommentaire.MaximumSize = new System.Drawing.Size(549, 154);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(126, 21);
            this.lblCommentaire.TabIndex = 30;
            this.lblCommentaire.Text = "Commentaire :";
            // 
            // lblCastingFiche
            // 
            this.lblCastingFiche.AutoSize = true;
            this.lblCastingFiche.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCastingFiche.Location = new System.Drawing.Point(593, 555);
            this.lblCastingFiche.MaximumSize = new System.Drawing.Size(549, 60);
            this.lblCastingFiche.Name = "lblCastingFiche";
            this.lblCastingFiche.Size = new System.Drawing.Size(81, 21);
            this.lblCastingFiche.TabIndex = 29;
            this.lblCastingFiche.Text = "Casting :";
            // 
            // lblSortie
            // 
            this.lblSortie.AutoSize = true;
            this.lblSortie.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortie.Location = new System.Drawing.Point(593, 155);
            this.lblSortie.Name = "lblSortie";
            this.lblSortie.Size = new System.Drawing.Size(145, 21);
            this.lblSortie.TabIndex = 28;
            this.lblSortie.Text = "Année de sortie :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Note :";
            // 
            // imgFiche
            // 
            this.imgFiche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgFiche.Location = new System.Drawing.Point(20, 26);
            this.imgFiche.Name = "imgFiche";
            this.imgFiche.Size = new System.Drawing.Size(538, 663);
            this.imgFiche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFiche.TabIndex = 26;
            this.imgFiche.TabStop = false;
            // 
            // FrmAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 765);
            this.Controls.Add(this.grpFiche);
            this.Controls.Add(this.grpType);
            this.Name = "FrmAjout";
            this.Text = "AJOUTER/MODIFIER UNE FICHE";
            this.Load += new System.EventHandler(this.FrmAjout_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpFiche.ResumeLayout(false);
            this.grpFiche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNote1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlateforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton radioJeu;
        private System.Windows.Forms.RadioButton radioSérie;
        private System.Windows.Forms.RadioButton radioFilm;
        private System.Windows.Forms.GroupBox grpFiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCommentaire;
        private System.Windows.Forms.TextBox txtBoxSpe;
        private System.Windows.Forms.TextBox txtBoxSortie;
        private System.Windows.Forms.TextBox txtBoxTitre;
        private System.Windows.Forms.Label lblSpecialInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPlateforme;
        private System.Windows.Forms.ComboBox cboNote;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblCastingInfo;
        private System.Windows.Forms.TextBox txtBoxCasting;
        private System.Windows.Forms.PictureBox imgNote6;
        private System.Windows.Forms.PictureBox imgNote2;
        private System.Windows.Forms.PictureBox imgNote5;
        private System.Windows.Forms.PictureBox imgNote4;
        private System.Windows.Forms.PictureBox imgNote3;
        private System.Windows.Forms.PictureBox imgNote1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox imgPlateforme;
        private System.Windows.Forms.Label lblPlateforme;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Label lblCastingFiche;
        private System.Windows.Forms.Label lblSortie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgFiche;
        private System.Windows.Forms.Label lblSpecialFiche;
        private System.Windows.Forms.ComboBox cboUtilisateur;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRealisateur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRealisateurInfo;
        private System.Windows.Forms.Label lblRealisateurFiche;
        private System.Windows.Forms.Label lblGenre;
    }
}