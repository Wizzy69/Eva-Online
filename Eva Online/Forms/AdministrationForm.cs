using static Eva_Online.Code.sqlConnection;
using System.Windows.Forms;
using Eva_Online.Code;

namespace Eva_Online.Forms
{
    public partial class AdministrationForm : Form
    {
        public AdministrationForm()
        {
            InitializeComponent();

            this.Load += (sender, e) => FormLoad();

        }

        private void InsertToGrid(int id)
        {
            dataGridView1.Rows.Clear();
            int qNumber = int.Parse(FetchData("exec Intrebari..getQuestionsCount '" + id + "'")[0]);
            for (int i = 1; i <= qNumber; i++)
            {
                string[] data = FetchData("USE Intrebari select * from QuestionDefinition where TestID = '" + id + "' and QuestionID = '" + i + "'");
                dataGridView1.Rows.Add(data);

            }

        }

        private void InsertToComboBox(int id)
        {
            string testName = FetchData($"exec Intrebari..getTestName '{id}'")[0];

            comboBoxTests.Items.Add(testName);
        }

        private void FormLoad()
        {
            int numberOfTests = int.Parse(FetchData("exec Intrebari..getTestsNumber")[0]);
            for (int i = 1; i <= numberOfTests; i++)
            {
                InsertToComboBox(i);
            }


            comboBoxTests.SelectedValueChanged += (sender, e) => InsertToGrid(comboBoxTests.SelectedIndex + 1);

            buttonAddText.Click += (snder, e) =>
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    try
                    {

                        string[] data = new string[]
                        {
                        r.Cells[0].Value.ToString(),
                        r.Cells[1].Value.ToString(),
                        r.Cells[2].Value.ToString(),
                        r.Cells[3].Value.ToString(),
                        r.Cells[4].Value.ToString(),
                        r.Cells[5].Value.ToString(),
                        r.Cells[6].Value.ToString(),
                        r.Cells[7].Value.ToString(),
                        r.Cells[8].Value.ToString()
                        };

                        Execute("Use intrebari delete from QuestionDefinition where TestID = '" + data[0] + "' and QuestionID = '" + data[1] + "'");
                        Execute($"Use intrebari insert into QuestionDefinition(TestID, QuestionID, QuestionText,AnswerType,Answer1,Answer2,Answer3,Answer4,CorrectAnswer)" +
                            $" values ('{data[0]}','{data[1]}','{data[2]}','{data[3]}','{data[4]}','{data[5]}','{data[6]}','{data[7]}','{data[8]}')");
                    }
                    catch { }


                }
            };
        }
    }
}
