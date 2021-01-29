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
    public partial class ShowAnswerForm : Form
    {
        int punctaj = 0;
        public ShowAnswerForm(Dictionary<string, string> submitted, string[] answers, string[] questions)
        {
            InitializeComponent();
            this.Load += (sender, e) => OnLoad(submitted, answers, questions);
        }
        public void OnLoad(Dictionary<string, string> submitted, string[] answers, string[] questions)
        {
            for (int i = 0; i < answers.Length; i++)
            {
                if (!submitted.ContainsKey(questions[i + 1]) || questions[i + 1] == null)
                    continue;
                if (submitted[questions[i + 1]] == answers[i])
                    punctaj++;
            }

            labelAnswer.Text = "Punctajul tau este : " + punctaj.ToString();
        }

        private void ShowAnswerForm_Load(object sender, EventArgs e)
        {
            labelAnswer.Parent = pictureBox1;
            labelAnswer.BackColor = Color.Transparent;
        }
    }
}
