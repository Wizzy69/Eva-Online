using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eva_Online.Forms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
            this.Load += (sender, e) => OnLoad();
        }
        public void OnLoad()
        {
            buttonExit.Click += (sender, e) =>
            {
                Environment.Exit(0);
            };

            buttonLoginAdmin.Click += (sender, e) =>
            {

                AdministrationForm form1 = new AdministrationForm();
                this.Hide();
                form1.ShowDialog();
            };
            buttonLoginElev.Click += (sender, e) =>
            {
                QuestionForm form1 = new QuestionForm();
                this.Hide();
                form1.ShowDialog();
            };
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            labelTitle.Parent = pictureBoxWallpaper;
            labelAdmin.Parent = pictureBoxWallpaper;
            labelAdminUsername.Parent = pictureBoxWallpaper;
            labelAdminParola.Parent = pictureBoxWallpaper;
            labelElev.Parent = pictureBoxWallpaper;
            labelElevUsername.Parent = pictureBoxWallpaper;
            labelElevParola.Parent = pictureBoxWallpaper;

            labelTitle.BackColor = Color.Transparent;
            labelAdmin.BackColor = Color.Transparent;
            labelAdminUsername.BackColor = Color.Transparent;
            labelAdminParola.BackColor = Color.Transparent;
            labelElev.BackColor = Color.Transparent;
            labelElevUsername.BackColor = Color.Transparent;
            labelElevParola.BackColor = Color.Transparent;
        }
    }
}
