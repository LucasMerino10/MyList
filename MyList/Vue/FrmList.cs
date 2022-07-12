using MyList.Controleur;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyList.Vue
{
    public partial class FrmList : Form
    {
        //Champs
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Controle controle;
        string backgroundImage = "background.jpg";

        public FrmList(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            imgBackground.ImageLocation = controle.GetImageDirectory() + backgroundImage;
            random = new Random();
            btnClose.Visible = false;
        }

        /// <summary>
        /// Permet de selectionner une couleur aléatoire parmis une liste
        /// </summary>
        /// <returns></returns>
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.GetColorList().Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.GetColorList().Count);
            }
            tempIndex = index;
            string couleur = ThemeColor.GetColorList()[index];
            return ColorTranslator.FromHtml(couleur);
        }

        /// <summary>
        /// Gère le changement de couleur quand un onglet est séléctionné
        /// </summary>
        /// <param name="btnSender"></param>
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && currentButton != (Button)btnSender)
            {
                DisableButton();
                Color couleur = SelectThemeColor();
                currentButton = (Button)btnSender;
                currentButton.BackColor = couleur;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panelTitre.BackColor = couleur;
                panelLogo.BackColor = ThemeColor.ChangeColorBrightness(couleur, -0.3);
                ThemeColor.PrimaryColor = couleur;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(couleur, -0.3);
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitre.Text = childForm.Text;
            btnClose.Visible = true;
        }

        private void btnFilms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFilms(controle, this), sender);
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSeries(controle, this), sender);
        }

        private void btnJeux_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmJeux(controle, this), sender);
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitre.Text = "MyList";
            panelTitre.BackColor = Color.FromArgb(34, 70, 124);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnClose.Visible = false;
        }
    }
}
