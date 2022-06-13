
namespace MyList.Vue
{
    partial class FrmList
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnJeux = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.btnFilms = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitre.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnJeux);
            this.panelMenu.Controls.Add(this.btnSeries);
            this.panelMenu.Controls.Add(this.btnFilms);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(237, 604);
            this.panelMenu.TabIndex = 0;
            // 
            // btnJeux
            // 
            this.btnJeux.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJeux.FlatAppearance.BorderSize = 0;
            this.btnJeux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJeux.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnJeux.Image = global::MyList.Properties.Resources.icons8_game_controller_30;
            this.btnJeux.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJeux.Location = new System.Drawing.Point(0, 240);
            this.btnJeux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJeux.Name = "btnJeux";
            this.btnJeux.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnJeux.Size = new System.Drawing.Size(237, 80);
            this.btnJeux.TabIndex = 3;
            this.btnJeux.Text = "  Jeux Video";
            this.btnJeux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJeux.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJeux.UseVisualStyleBackColor = true;
            this.btnJeux.Click += new System.EventHandler(this.btnJeux_Click);
            // 
            // btnSeries
            // 
            this.btnSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeries.FlatAppearance.BorderSize = 0;
            this.btnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeries.Image = global::MyList.Properties.Resources.icons8_tv_show_30;
            this.btnSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeries.Location = new System.Drawing.Point(0, 160);
            this.btnSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSeries.Size = new System.Drawing.Size(237, 80);
            this.btnSeries.TabIndex = 2;
            this.btnSeries.Text = "  Series";
            this.btnSeries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // btnFilms
            // 
            this.btnFilms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilms.FlatAppearance.BorderSize = 0;
            this.btnFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilms.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilms.Image = global::MyList.Properties.Resources.icons8_cinema_30;
            this.btnFilms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilms.Location = new System.Drawing.Point(0, 80);
            this.btnFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFilms.Size = new System.Drawing.Size(237, 80);
            this.btnFilms.TabIndex = 1;
            this.btnFilms.Text = "  Films";
            this.btnFilms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilms.UseVisualStyleBackColor = true;
            this.btnFilms.Click += new System.EventHandler(this.btnFilms_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(237, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(68, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "MyList";
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(124)))));
            this.panelTitre.Controls.Add(this.lblTitre);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitre.Location = new System.Drawing.Point(237, 0);
            this.panelTitre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(1141, 80);
            this.panelTitre.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitre.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(0, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(1141, 36);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "MyList";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(237, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1141, 524);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MyList.Properties.Resources.MyListLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(246, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 604);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitre);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimumSize = new System.Drawing.Size(1400, 660);
            this.Name = "FrmList";
            this.Text = "MyList";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitre.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnFilms;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnJeux;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

