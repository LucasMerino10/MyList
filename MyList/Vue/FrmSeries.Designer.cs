
namespace MyList.Vue
{
    partial class FrmSeries
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.grpUtilisateur = new System.Windows.Forms.GroupBox();
            this.radioLucas = new System.Windows.Forms.RadioButton();
            this.radioClemence = new System.Windows.Forms.RadioButton();
            this.radioTous = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblSortie = new System.Windows.Forms.Label();
            this.lblSaison = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.lblPlateforme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpFiche.SuspendLayout();
            this.grpUtilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiche
            // 
            this.grpFiche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiche.Controls.Add(this.panel1);
            this.grpFiche.Controls.Add(this.pictureBox2);
            this.grpFiche.Controls.Add(this.lblPlateforme);
            this.grpFiche.Controls.Add(this.lblUtilisateur);
            this.grpFiche.Controls.Add(this.lblDate);
            this.grpFiche.Controls.Add(this.lblCommentaire);
            this.grpFiche.Controls.Add(this.lblSaison);
            this.grpFiche.Controls.Add(this.lblSortie);
            this.grpFiche.Controls.Add(this.lblNote);
            this.grpFiche.Controls.Add(this.pictureBox1);
            this.grpFiche.Location = new System.Drawing.Point(490, 27);
            this.grpFiche.Name = "grpFiche";
            this.grpFiche.Size = new System.Drawing.Size(1184, 587);
            this.grpFiche.TabIndex = 17;
            this.grpFiche.TabStop = false;
            this.grpFiche.Text = "Fiche";
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(20, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(510, 54);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Stranger Things 4";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Location = new System.Drawing.Point(357, 574);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 39);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Location = new System.Drawing.Point(190, 574);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(95, 39);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.Location = new System.Drawing.Point(23, 575);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(95, 39);
            this.btnAjout.TabIndex = 14;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // grpUtilisateur
            // 
            this.grpUtilisateur.Controls.Add(this.radioLucas);
            this.grpUtilisateur.Controls.Add(this.radioClemence);
            this.grpUtilisateur.Controls.Add(this.radioTous);
            this.grpUtilisateur.Location = new System.Drawing.Point(23, 27);
            this.grpUtilisateur.Name = "grpUtilisateur";
            this.grpUtilisateur.Size = new System.Drawing.Size(284, 125);
            this.grpUtilisateur.TabIndex = 13;
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
            // 
            // radioClemence
            // 
            this.radioClemence.AutoSize = true;
            this.radioClemence.Location = new System.Drawing.Point(6, 55);
            this.radioClemence.Name = "radioClemence";
            this.radioClemence.Size = new System.Drawing.Size(105, 24);
            this.radioClemence.TabIndex = 1;
            this.radioClemence.Text = "Clémence";
            this.radioClemence.UseVisualStyleBackColor = true;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(429, 379);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(589, 265);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(43, 20);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Note";
            // 
            // lblSortie
            // 
            this.lblSortie.AutoSize = true;
            this.lblSortie.Location = new System.Drawing.Point(589, 105);
            this.lblSortie.Name = "lblSortie";
            this.lblSortie.Size = new System.Drawing.Size(121, 20);
            this.lblSortie.TabIndex = 3;
            this.lblSortie.Text = "Année de sortie";
            // 
            // lblSaison
            // 
            this.lblSaison.AutoSize = true;
            this.lblSaison.Location = new System.Drawing.Point(589, 185);
            this.lblSaison.Name = "lblSaison";
            this.lblSaison.Size = new System.Drawing.Size(58, 20);
            this.lblSaison.TabIndex = 4;
            this.lblSaison.Text = "Saison";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(589, 345);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(104, 20);
            this.lblCommentaire.TabIndex = 5;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(589, 543);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Ajouté le";
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Location = new System.Drawing.Point(887, 543);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(82, 20);
            this.lblUtilisateur.TabIndex = 7;
            this.lblUtilisateur.Text = "Ajouté par";
            // 
            // lblPlateforme
            // 
            this.lblPlateforme.AutoSize = true;
            this.lblPlateforme.Location = new System.Drawing.Point(887, 105);
            this.lblPlateforme.Name = "lblPlateforme";
            this.lblPlateforme.Size = new System.Drawing.Size(86, 20);
            this.lblPlateforme.TabIndex = 9;
            this.lblPlateforme.Text = "Plateforme";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Location = new System.Drawing.Point(593, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 54);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1007, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 538);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 640);
            this.Controls.Add(this.grpFiche);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.grpUtilisateur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSeries";
            this.Text = "Series";
            this.Load += new System.EventHandler(this.FrmSeries_Load);
            this.grpFiche.ResumeLayout(false);
            this.grpFiche.PerformLayout();
            this.grpUtilisateur.ResumeLayout(false);
            this.grpUtilisateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiche;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.GroupBox grpUtilisateur;
        private System.Windows.Forms.RadioButton radioLucas;
        private System.Windows.Forms.RadioButton radioClemence;
        private System.Windows.Forms.RadioButton radioTous;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Label lblSaison;
        private System.Windows.Forms.Label lblSortie;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPlateforme;
        private System.Windows.Forms.Panel panel1;
    }
}