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
    public partial class QuestionForm : Form
    {
        private int timeLeft = 3600;
        private string[] questions = new string[11];
        private Dictionary<string, string[]> answers = new Dictionary<string, string[]>();
        private Dictionary<string, string> submitted = new Dictionary<string, string>();
        private int questionDisplayed = 1;
        private Point point = Point.Empty;
        public QuestionForm(int testID)
        {
            InitializeComponent();
            Start(testID);
            this.Load += (sender, e) => OnLoad();

        }

        private void Start(int testID)
        {
            int qNumber = int.Parse(FetchData("exec Intrebari..getQuestionsCount '" + testID + "'")[0]);
            for (int i = 1; i <= qNumber; i++)
            {
                questions[i] = FetchData("USE Intrebari select QuestionText from QuestionDefinition where TestID = '" + testID + "' and QuestionID = '" + i + "'")[0];
                string[] answers = FetchData("USE Intrebari select Answer1,Answer2,Answer3,Answer4,CorrectAnswer from QuestionDefinition where TestID = '" + testID + "' and QuestionText = '" + questions[i] + "'");
                this.answers.Add(questions[i], answers);
            }

            labelQuestionNumber.Text = $"Question {questionDisplayed} of 10";
            labelQuestion.Text = questions[questionDisplayed];

            radioButtonAnswer1.Text = answers[labelQuestion.Text][0];
            radioButtonAnswer2.Text = answers[labelQuestion.Text][1];
            radioButtonAnswer3.Text = answers[labelQuestion.Text][2];
            radioButtonAnswer4.Text = answers[labelQuestion.Text][3];
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
                Environment.Exit(0);
            };

            timer1.Tick += (sender, e) =>
            {
                if (timeLeft > 0)
                {
                    timeLeft = timeLeft - 1;
                    var timespan = TimeSpan.FromSeconds(timeLeft);
                    labelTimer.Text = "Time left: " + timespan.ToString(@"mm\:ss");

                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Time's up!", "Time has elapsed", MessageBoxButtons.OK);
                    buttonSubmit.PerformClick();
                }
            };



            buttonRight.Click += (sender, e) =>
            {
                if (questionDisplayed == 10)
                    questionDisplayed = 0;
                questionDisplayed++;
                labelQuestion.Text = questions[questionDisplayed];
                labelQuestionNumber.Text = $"Question {questionDisplayed} of 10";
                radioButtonAnswer1.Text = answers[labelQuestion.Text][0];
                radioButtonAnswer2.Text = answers[labelQuestion.Text][1];
                radioButtonAnswer3.Text = answers[labelQuestion.Text][2];
                radioButtonAnswer4.Text = answers[labelQuestion.Text][3];


                radioButtonAnswer1.Checked = false;
                radioButtonAnswer2.Checked = false;
                radioButtonAnswer3.Checked = false;
                radioButtonAnswer4.Checked = false;


            };

            buttonLeft.Click += (sender, e) =>
            {
                if (questionDisplayed == 10)
                    questionDisplayed = 0;
                questionDisplayed--;
                labelQuestion.Text = questions[questionDisplayed];
                labelQuestionNumber.Text = $"Question {questionDisplayed} of 10";
                radioButtonAnswer1.Text = answers[labelQuestion.Text][0];
                radioButtonAnswer2.Text = answers[labelQuestion.Text][1];
                radioButtonAnswer3.Text = answers[labelQuestion.Text][2];
                radioButtonAnswer4.Text = answers[labelQuestion.Text][3];
                radioButtonAnswer1.Checked = false;
                radioButtonAnswer2.Checked = false;
                radioButtonAnswer3.Checked = false;
                radioButtonAnswer4.Checked = false;

            };

            radioButtonAnswer1.CheckedChanged += (sender, e) =>
            {
                try
                {
                    submitted.Add(questions[questionDisplayed], radioButtonAnswer1.Text);
                }
                catch
                {
                    submitted.Remove(questions[questionDisplayed]);
                    submitted.Add(questions[questionDisplayed], radioButtonAnswer1.Text);
                }
            };
            radioButtonAnswer2.CheckedChanged += (sender, e) =>
            {
                try
                {
                    submitted.Add(questions[questionDisplayed], radioButtonAnswer2.Text);
                }
                catch
                {
                    submitted.Remove(questions[questionDisplayed]);
                    submitted.Add(questions[questionDisplayed], radioButtonAnswer2.Text);
                }

            };
            radioButtonAnswer3.CheckedChanged += (sender, e) =>
            {
                try
                {
                    submitted.Add(questions[questionDisplayed], radioButtonAnswer3.Text);
                }
                catch
                {
                    submitted.Remove(questions[questionDisplayed]);
                    submitted.Add(questions[questionDisplayed], radioButtonAnswer3.Text);
                }
            };
            radioButtonAnswer4.CheckedChanged += (sender, e) =>
            {
                try
                {
                    submitted.Add(questions[questionDisplayed], radioButtonAnswer4.Text);
                }
                catch
                {
                    submitted.Remove(questions[questionDisplayed]);
                    submitted.Add(questions[questionDisplayed], radioButtonAnswer4.Text);
                }
            };

            buttonSubmit.Click += (sender, e) =>
            {
                string[] ras = new string[10];
                int len = answers.Count;
                for (int i = 0; i < len; i++)
                    ras[i] = answers[questions[i + 1]][4];
                ShowAnswerForm form = new ShowAnswerForm(submitted, ras, questions);
                this.Hide();
                form.ShowDialog();
                this.Close();

            };

        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
