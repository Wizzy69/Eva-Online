using Eva_Online.Code;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using static Eva_Online.Code.sqlConnection;
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

        private void InsertToComboBox(int id)
        {
            string testName = FetchData($"exec Intrebari..getTestName '{id}'")[0];

            comboBox1.Items.Add(testName);
        }

        public void OnLoad()
        {

            if (!sqlConnection.Start())
                System.Environment.Exit(0);

            buttonExit.Click += (sender, e) =>
            {
                Environment.Exit(0);
            };

            buttonLoginAdmin.Click += (sender, e) =>
            {
                if (!sqlConnection.Login(true, textBoxAdminUsername.Text, textBoxAdminPassword.Text))
                {
                    MessageBox.Show("Invalid account");
                    return;
                }

                textBoxAdminPassword.Text = "";
                textBoxAdminUsername.Text = "";
                AdministrationForm form1 = new AdministrationForm();
                this.Hide();
                form1.ShowDialog();
                this.Show();
            };
            buttonLoginElev.Click += (sender, e) =>
            {
                if (!sqlConnection.Login(false, textBoxElevUsername.Text, textBoxElevPassword.Text))
                {
                    MessageBox.Show("Invalid account");
                    return;
                }
                textBoxElevPassword.Text = "";
                textBoxElevUsername.Text = "";
                QuestionForm form1 = new QuestionForm(comboBox1.SelectedIndex + 1);
                this.Hide();
                form1.ShowDialog();
                this.Show();
            };

            int numberOfTests = int.Parse(FetchData("exec Intrebari..getTestsNumber")[0]);
            for (int i = 1; i <= numberOfTests; i++)
            {
                InsertToComboBox(i);
            }

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
