
namespace Eva_Online.Forms
{
    partial class Form1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelElev = new System.Windows.Forms.Label();
            this.labelAdminUsername = new System.Windows.Forms.Label();
            this.labelAdminParola = new System.Windows.Forms.Label();
            this.labelElevUsername = new System.Windows.Forms.Label();
            this.labelElevParola = new System.Windows.Forms.Label();
            this.textBoxAdminUsername = new System.Windows.Forms.TextBox();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.textBoxElevUsername = new System.Windows.Forms.TextBox();
            this.textBoxElevPassword = new System.Windows.Forms.TextBox();
            this.buttonLoginAdmin = new System.Windows.Forms.Button();
            this.buttonLoginElev = new System.Windows.Forms.Button();
            this.pictureBoxWallpaper = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(442, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(138, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Evaluare";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(12, 76);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(125, 24);
            this.labelAdmin.TabIndex = 1;
            this.labelAdmin.Text = "Login Admin";
            // 
            // labelElev
            // 
            this.labelElev.AutoSize = true;
            this.labelElev.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElev.Location = new System.Drawing.Point(8, 395);
            this.labelElev.Name = "labelElev";
            this.labelElev.Size = new System.Drawing.Size(107, 24);
            this.labelElev.TabIndex = 2;
            this.labelElev.Text = "Login Elev";
            // 
            // labelAdminUsername
            // 
            this.labelAdminUsername.AutoSize = true;
            this.labelAdminUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminUsername.Location = new System.Drawing.Point(12, 114);
            this.labelAdminUsername.Name = "labelAdminUsername";
            this.labelAdminUsername.Size = new System.Drawing.Size(98, 23);
            this.labelAdminUsername.TabIndex = 3;
            this.labelAdminUsername.Text = "Username :";
            // 
            // labelAdminParola
            // 
            this.labelAdminParola.AutoSize = true;
            this.labelAdminParola.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminParola.Location = new System.Drawing.Point(12, 158);
            this.labelAdminParola.Name = "labelAdminParola";
            this.labelAdminParola.Size = new System.Drawing.Size(68, 23);
            this.labelAdminParola.TabIndex = 4;
            this.labelAdminParola.Text = "Parola :";
            // 
            // labelElevUsername
            // 
            this.labelElevUsername.AutoSize = true;
            this.labelElevUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElevUsername.Location = new System.Drawing.Point(12, 433);
            this.labelElevUsername.Name = "labelElevUsername";
            this.labelElevUsername.Size = new System.Drawing.Size(98, 23);
            this.labelElevUsername.TabIndex = 5;
            this.labelElevUsername.Text = "Username :";
            // 
            // labelElevParola
            // 
            this.labelElevParola.AutoSize = true;
            this.labelElevParola.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElevParola.Location = new System.Drawing.Point(12, 470);
            this.labelElevParola.Name = "labelElevParola";
            this.labelElevParola.Size = new System.Drawing.Size(68, 23);
            this.labelElevParola.TabIndex = 6;
            this.labelElevParola.Text = "Parola :";
            // 
            // textBoxAdminUsername
            // 
            this.textBoxAdminUsername.Location = new System.Drawing.Point(118, 119);
            this.textBoxAdminUsername.Name = "textBoxAdminUsername";
            this.textBoxAdminUsername.Size = new System.Drawing.Size(173, 20);
            this.textBoxAdminUsername.TabIndex = 7;
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Location = new System.Drawing.Point(118, 162);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(173, 20);
            this.textBoxAdminPassword.TabIndex = 8;
            // 
            // textBoxElevUsername
            // 
            this.textBoxElevUsername.Location = new System.Drawing.Point(118, 433);
            this.textBoxElevUsername.Name = "textBoxElevUsername";
            this.textBoxElevUsername.Size = new System.Drawing.Size(173, 20);
            this.textBoxElevUsername.TabIndex = 9;
            // 
            // textBoxElevPassword
            // 
            this.textBoxElevPassword.Location = new System.Drawing.Point(118, 470);
            this.textBoxElevPassword.Name = "textBoxElevPassword";
            this.textBoxElevPassword.Size = new System.Drawing.Size(170, 20);
            this.textBoxElevPassword.TabIndex = 10;
            // 
            // buttonLoginAdmin
            // 
            this.buttonLoginAdmin.BackColor = System.Drawing.Color.Aqua;
            this.buttonLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAdmin.Location = new System.Drawing.Point(12, 200);
            this.buttonLoginAdmin.Name = "buttonLoginAdmin";
            this.buttonLoginAdmin.Size = new System.Drawing.Size(85, 35);
            this.buttonLoginAdmin.TabIndex = 11;
            this.buttonLoginAdmin.Text = "Login";
            this.buttonLoginAdmin.UseVisualStyleBackColor = false;
            // 
            // buttonLoginElev
            // 
            this.buttonLoginElev.BackColor = System.Drawing.Color.Aqua;
            this.buttonLoginElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginElev.Location = new System.Drawing.Point(12, 509);
            this.buttonLoginElev.Name = "buttonLoginElev";
            this.buttonLoginElev.Size = new System.Drawing.Size(85, 35);
            this.buttonLoginElev.TabIndex = 12;
            this.buttonLoginElev.Text = "Login";
            this.buttonLoginElev.UseVisualStyleBackColor = false;
            // 
            // pictureBoxWallpaper
            // 
            this.pictureBoxWallpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWallpaper.Image = global::Eva_Online.Properties.Resources.html_background_2;
            this.pictureBoxWallpaper.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxWallpaper.Name = "pictureBoxWallpaper";
            this.pictureBoxWallpaper.Size = new System.Drawing.Size(1043, 653);
            this.pictureBoxWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWallpaper.TabIndex = 13;
            this.pictureBoxWallpaper.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.BackgroundImage = global::Eva_Online.Properties.Resources.Image_Exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(956, 564);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 77);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 653);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLoginElev);
            this.Controls.Add(this.buttonLoginAdmin);
            this.Controls.Add(this.textBoxElevPassword);
            this.Controls.Add(this.textBoxElevUsername);
            this.Controls.Add(this.textBoxAdminPassword);
            this.Controls.Add(this.textBoxAdminUsername);
            this.Controls.Add(this.labelElevParola);
            this.Controls.Add(this.labelElevUsername);
            this.Controls.Add(this.labelAdminParola);
            this.Controls.Add(this.labelAdminUsername);
            this.Controls.Add(this.labelElev);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxWallpaper);
            this.Name = "Form1";
            this.Text = "Online Evaluation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelElev;
        private System.Windows.Forms.Label labelAdminUsername;
        private System.Windows.Forms.Label labelAdminParola;
        private System.Windows.Forms.Label labelElevUsername;
        private System.Windows.Forms.Label labelElevParola;
        private System.Windows.Forms.TextBox textBoxAdminUsername;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.TextBox textBoxElevUsername;
        private System.Windows.Forms.TextBox textBoxElevPassword;
        private System.Windows.Forms.Button buttonLoginAdmin;
        private System.Windows.Forms.Button buttonLoginElev;
        private System.Windows.Forms.PictureBox pictureBoxWallpaper;
        private System.Windows.Forms.Button buttonExit;
    }
}

