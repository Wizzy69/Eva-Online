
namespace Eva_Online.Forms
{
    partial class QuestionForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.radioButtonAnswer1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer4 = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNumber.Location = new System.Drawing.Point(12, 88);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(152, 23);
            this.labelQuestionNumber.TabIndex = 2;
            this.labelQuestionNumber.Text = "Question 1 of 10";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(55, 127);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(424, 33);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "The Question will be displayed here";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(709, 85);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(52, 19);
            this.labelTimer.TabIndex = 12;
            this.labelTimer.Text = "00 : 00";
            // 
            // radioButtonAnswer1
            // 
            this.radioButtonAnswer1.AutoSize = true;
            this.radioButtonAnswer1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer1.Location = new System.Drawing.Point(17, 285);
            this.radioButtonAnswer1.Name = "radioButtonAnswer1";
            this.radioButtonAnswer1.Size = new System.Drawing.Size(107, 27);
            this.radioButtonAnswer1.TabIndex = 13;
            this.radioButtonAnswer1.TabStop = true;
            this.radioButtonAnswer1.Text = "Answer 1";
            this.radioButtonAnswer1.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswer2
            // 
            this.radioButtonAnswer2.AutoSize = true;
            this.radioButtonAnswer2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer2.Location = new System.Drawing.Point(17, 320);
            this.radioButtonAnswer2.Name = "radioButtonAnswer2";
            this.radioButtonAnswer2.Size = new System.Drawing.Size(107, 27);
            this.radioButtonAnswer2.TabIndex = 14;
            this.radioButtonAnswer2.TabStop = true;
            this.radioButtonAnswer2.Text = "Answer 2";
            this.radioButtonAnswer2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswer3
            // 
            this.radioButtonAnswer3.AutoSize = true;
            this.radioButtonAnswer3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer3.Location = new System.Drawing.Point(17, 353);
            this.radioButtonAnswer3.Name = "radioButtonAnswer3";
            this.radioButtonAnswer3.Size = new System.Drawing.Size(107, 27);
            this.radioButtonAnswer3.TabIndex = 15;
            this.radioButtonAnswer3.TabStop = true;
            this.radioButtonAnswer3.Text = "Answer 3";
            this.radioButtonAnswer3.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswer4
            // 
            this.radioButtonAnswer4.AutoSize = true;
            this.radioButtonAnswer4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer4.Location = new System.Drawing.Point(17, 386);
            this.radioButtonAnswer4.Name = "radioButtonAnswer4";
            this.radioButtonAnswer4.Size = new System.Drawing.Size(107, 27);
            this.radioButtonAnswer4.TabIndex = 16;
            this.radioButtonAnswer4.TabStop = true;
            this.radioButtonAnswer4.Text = "Answer 4";
            this.radioButtonAnswer4.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.White;
            this.buttonSubmit.BackgroundImage = global::Eva_Online.Properties.Resources.Image_Check;
            this.buttonSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubmit.Location = new System.Drawing.Point(713, 368);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 70);
            this.buttonSubmit.TabIndex = 17;
            this.buttonSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.BackgroundImage = global::Eva_Online.Properties.Resources.Image_Exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(724, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 70);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.BackgroundImage = global::Eva_Online.Properties.Resources.Image_Right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(88, 12);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(70, 70);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRight.UseVisualStyleBackColor = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.AutoSize = true;
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.BackgroundImage = global::Eva_Online.Properties.Resources.Image_Left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(6, 12);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(70, 70);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLeft.UseVisualStyleBackColor = false;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.radioButtonAnswer4);
            this.Controls.Add(this.radioButtonAnswer3);
            this.Controls.Add(this.radioButtonAnswer2);
            this.Controls.Add(this.radioButtonAnswer1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelQuestionNumber);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.RadioButton radioButtonAnswer1;
        private System.Windows.Forms.RadioButton radioButtonAnswer2;
        private System.Windows.Forms.RadioButton radioButtonAnswer3;
        private System.Windows.Forms.RadioButton radioButtonAnswer4;
        private System.Windows.Forms.Button buttonSubmit;
    }
}