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
    public partial class QuestionForm : Form
    {
        private Point point = Point.Empty;
        public QuestionForm()
        {
            InitializeComponent();
            this.Load += (sender, e) => OnLoad();

        }
        public void OnLoad()
        {
            groupBox1.MouseDown += (sender, e) => point = new Point(e.X, e.Y);
            groupBox1.MouseMove += (sender, e) =>
            {
                if (point.IsEmpty)
                {
                    return;
                }
                this.Location = new Point(this.Location.X + (e.X - point.X), this.Location.Y + (e.Y - point.Y));

            };
            groupBox1.MouseUp += (sender, e) => point = Point.Empty;
            buttonExit.Click += (sender, e) =>
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            };

            timer1.Tick += (sender, e) =>
            {
                labelTimer.Text = DateTime.Now.ToLongTimeString();
            };


        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
