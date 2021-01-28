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

        public QuestionForm()
        {
            InitializeComponent();
            this.Load += (sender, e) => OnLoad();

        }
        public void OnLoad()
        {
            buttonExit.Click += (sender, e) =>
            {

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
