
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.Elev = new System.Windows.Forms.Label();
            this.username_admin = new System.Windows.Forms.Label();
            this.password_admin = new System.Windows.Forms.Label();
            this.username_elev = new System.Windows.Forms.Label();
            this.clasa_elev = new System.Windows.Forms.Label();
            this.username_admin1 = new System.Windows.Forms.TextBox();
            this.password_admin1 = new System.Windows.Forms.TextBox();
            this.username_elev1 = new System.Windows.Forms.TextBox();
            this.clasa_elev1 = new System.Windows.Forms.TextBox();
            this.Login_admin = new System.Windows.Forms.Button();
            this.Login_elev = new System.Windows.Forms.Button();
            this.Wallpaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(442, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(138, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Evaluare";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(184, 97);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(125, 24);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Login Admin";
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Elev
            // 
            this.Elev.AutoSize = true;
            this.Elev.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elev.Location = new System.Drawing.Point(184, 396);
            this.Elev.Name = "Elev";
            this.Elev.Size = new System.Drawing.Size(107, 24);
            this.Elev.TabIndex = 2;
            this.Elev.Text = "Login Elev";
            // 
            // username_admin
            // 
            this.username_admin.AutoSize = true;
            this.username_admin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_admin.Location = new System.Drawing.Point(93, 145);
            this.username_admin.Name = "username_admin";
            this.username_admin.Size = new System.Drawing.Size(89, 23);
            this.username_admin.TabIndex = 3;
            this.username_admin.Text = "Username";
            this.username_admin.Click += new System.EventHandler(this.username_admin_Click);
            // 
            // password_admin
            // 
            this.password_admin.AutoSize = true;
            this.password_admin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_admin.Location = new System.Drawing.Point(123, 183);
            this.password_admin.Name = "password_admin";
            this.password_admin.Size = new System.Drawing.Size(59, 23);
            this.password_admin.TabIndex = 4;
            this.password_admin.Text = "Parola";
            // 
            // username_elev
            // 
            this.username_elev.AutoSize = true;
            this.username_elev.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_elev.Location = new System.Drawing.Point(93, 437);
            this.username_elev.Name = "username_elev";
            this.username_elev.Size = new System.Drawing.Size(89, 23);
            this.username_elev.TabIndex = 5;
            this.username_elev.Text = "Username";
            // 
            // clasa_elev
            // 
            this.clasa_elev.AutoSize = true;
            this.clasa_elev.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clasa_elev.Location = new System.Drawing.Point(132, 467);
            this.clasa_elev.Name = "clasa_elev";
            this.clasa_elev.Size = new System.Drawing.Size(50, 23);
            this.clasa_elev.TabIndex = 6;
            this.clasa_elev.Text = "Clasa";
            // 
            // username_admin1
            // 
            this.username_admin1.Location = new System.Drawing.Point(188, 145);
            this.username_admin1.Name = "username_admin1";
            this.username_admin1.Size = new System.Drawing.Size(100, 20);
            this.username_admin1.TabIndex = 7;
            // 
            // password_admin1
            // 
            this.password_admin1.Location = new System.Drawing.Point(188, 183);
            this.password_admin1.Name = "password_admin1";
            this.password_admin1.Size = new System.Drawing.Size(100, 20);
            this.password_admin1.TabIndex = 8;
            // 
            // username_elev1
            // 
            this.username_elev1.Location = new System.Drawing.Point(188, 437);
            this.username_elev1.Name = "username_elev1";
            this.username_elev1.Size = new System.Drawing.Size(100, 20);
            this.username_elev1.TabIndex = 9;
            // 
            // clasa_elev1
            // 
            this.clasa_elev1.Location = new System.Drawing.Point(188, 470);
            this.clasa_elev1.Name = "clasa_elev1";
            this.clasa_elev1.Size = new System.Drawing.Size(100, 20);
            this.clasa_elev1.TabIndex = 10;
            // 
            // Login_admin
            // 
            this.Login_admin.BackColor = System.Drawing.Color.Aquamarine;
            this.Login_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_admin.Location = new System.Drawing.Point(188, 209);
            this.Login_admin.Name = "Login_admin";
            this.Login_admin.Size = new System.Drawing.Size(100, 38);
            this.Login_admin.TabIndex = 11;
            this.Login_admin.Text = "Login";
            this.Login_admin.UseVisualStyleBackColor = false;
            // 
            // Login_elev
            // 
            this.Login_elev.BackColor = System.Drawing.Color.Aquamarine;
            this.Login_elev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_elev.Location = new System.Drawing.Point(188, 496);
            this.Login_elev.Name = "Login_elev";
            this.Login_elev.Size = new System.Drawing.Size(100, 38);
            this.Login_elev.TabIndex = 12;
            this.Login_elev.Text = "Login";
            this.Login_elev.UseVisualStyleBackColor = false;
            // 
            // Wallpaper
            // 
            this.Wallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wallpaper.Image = ((System.Drawing.Image)(resources.GetObject("Wallpaper.Image")));
            this.Wallpaper.Location = new System.Drawing.Point(0, 0);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.Size = new System.Drawing.Size(1043, 653);
            this.Wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Wallpaper.TabIndex = 13;
            this.Wallpaper.TabStop = false;
            this.Wallpaper.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 653);
            this.Controls.Add(this.Login_elev);
            this.Controls.Add(this.Login_admin);
            this.Controls.Add(this.clasa_elev1);
            this.Controls.Add(this.username_elev1);
            this.Controls.Add(this.password_admin1);
            this.Controls.Add(this.username_admin1);
            this.Controls.Add(this.clasa_elev);
            this.Controls.Add(this.username_elev);
            this.Controls.Add(this.password_admin);
            this.Controls.Add(this.username_admin);
            this.Controls.Add(this.Elev);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Wallpaper);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label Elev;
        private System.Windows.Forms.Label username_admin;
        private System.Windows.Forms.Label password_admin;
        private System.Windows.Forms.Label username_elev;
        private System.Windows.Forms.Label clasa_elev;
        private System.Windows.Forms.TextBox username_admin1;
        private System.Windows.Forms.TextBox password_admin1;
        private System.Windows.Forms.TextBox username_elev1;
        private System.Windows.Forms.TextBox clasa_elev1;
        private System.Windows.Forms.Button Login_admin;
        private System.Windows.Forms.Button Login_elev;
        private System.Windows.Forms.PictureBox Wallpaper;
    }
}

