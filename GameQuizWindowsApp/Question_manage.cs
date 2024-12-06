using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Helpers;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GameQuizWindowsApp
{
    public partial class Question_manage : Form
    {
        private Form currentFormChild;

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // Close current form if any
            }
            currentFormChild = childForm; // Assign new form
            childForm.TopLevel = false; // Set to be embedded in panel
            childForm.FormBorderStyle = FormBorderStyle.None; // No border
            childForm.Dock = DockStyle.Fill; // Fill the panel
            panel_Body.Controls.Add(childForm); // Add form to panel
            panel_Body.Tag = childForm; // Assign tags to the panel
            childForm.BringToFront(); // Move the form to the top
            childForm.Show();
        }

        private void Question_manage_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView(dataGridView_question);
        }

        public Question_manage()
        {
            InitializeComponent();
            LoadQuestions();
            LoadQuestionTypes();
            btn_search.Click += Btn_search_Click;
            ConfigureDataGridView(dataGridView_question);
        }

        private void LoadQuestions()
        {
            try
            {
                string query = "SELECT q.id, q.text AS question_text, q.id_type " +
                               "FROM question q";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dataGridView_question.DataSource = dt;

                dataGridView_question.Columns["id"].Visible = true;
                dataGridView_question.Columns["id_type"].Visible = true;

                dataGridView_question.Columns["question_text"].HeaderText = "Question";
                dataGridView_question.Columns["id_type"].HeaderText = "Id_Type";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions: " + ex.Message);
            }
        }


        private void ConfigureDataGridView(DataGridView dataGridView)
        {
            dataGridView.EnableHeadersVisualStyles = false;
            // 1. Change the color of column header cells
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
            // 2. Make sure the columns span the full width of the grid
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 3. Customize the width of the columns
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            // 4. Adjust the background color of data cells
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            // 5. Set the borders of the cells
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.GridColor = Color.Gray;
            // 7. Edit the color of the header row
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.RowHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            // 8. Set up the selection mode
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;// Select the entire row when clicking
            dataGridView.MultiSelect = false;// Do not allow selecting multiple rows at once
        }

        private void LoadQuestionTypes()
        {
            try
            {
                string query = "SELECT name FROM type";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                cbb_typequestion.Items.Add("All");
                foreach (DataRow row in dt.Rows)
                {
                    cbb_typequestion.Items.Add(row["name"].ToString());
                }

                cbb_typequestion.SelectedIndex = 0; // Set default value to "All"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading question types: " + ex.Message);
            }
        }


        private void Btn_search_Click(object sender, EventArgs e)
        {
            string selectedType = cbb_typequestion.SelectedItem.ToString();
            string searchKeyword = textBox_search.Text.Trim();

            try
            {
                string query = "SELECT q.id, q.text AS question_text, q.id_type " +
                               "FROM question q " +
                               "JOIN type t ON q.id_type = t.id " +
                               "WHERE (@type = 'All' OR t.name = @type) " +
                               "AND (q.text LIKE @search)";

                var parameters = new List<MySqlParameter>
        {
            new MySqlParameter("@type", selectedType),
            new MySqlParameter("@search", "%" + searchKeyword + "%")
        };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
                dataGridView_question.DataSource = dt;

                dataGridView_question.Columns["id"].HeaderText = "ID";
                dataGridView_question.Columns["question_text"].HeaderText = "Question";
                dataGridView_question.Columns["id_type"].HeaderText = "Id_Type";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_question.SelectedRows.Count > 0)
            {
                int questionId = Convert.ToInt32(dataGridView_question.SelectedRows[0].Cells["id"].Value);
                string questionText = dataGridView_question.SelectedRows[0].Cells["question_text"].Value.ToString();

                Question_delete deleteForm = new Question_delete(questionId, questionText);
                deleteForm.QuestionDeleted += LoadQuestions;
                OpenChildForm(deleteForm);
            }
            else
            {
                MessageBox.Show("Please select the question to delete.");
            }
        }

        private int GetSelectedQuestionId()
        {
            if (dataGridView_question.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView_question.SelectedRows[0].Cells["id"].Value);
            }
            else
            {
                MessageBox.Show("Please select a question.");
                return -1;
            }
        }

        private string GetSelectedAnswer(int answerIndex)
        {
            int questionId = GetSelectedQuestionId();

            if (questionId <= 0)
            {
                MessageBox.Show("No question selected.");
                return string.Empty;
            }

            string query = "SELECT answer FROM answer WHERE id_question = @questionId ORDER BY id LIMIT @answerIndex, 1";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@questionId", questionId),
        new MySqlParameter("@answerIndex", answerIndex - 1) 
            };

            try
            {
                object result = DatabaseHelper.ExecuteScalar(query, parameters);
                return result?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while getting answer: " + ex.Message);
                return string.Empty;
            }
        }


        private string[] GetMultichoiceAnswers()
        {
            int questionId = GetSelectedQuestionId();
            string[] answers = new string[4];

            if (questionId <= 0)
            {
                MessageBox.Show("No question selected.");
                return answers;
            }

            string query = "SELECT answer FROM answer WHERE id_question = @questionId ORDER BY id LIMIT 4";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@questionId", questionId)
            };

            try
            {
                DataTable dataTable = DatabaseHelper.ExecuteQuery(query, parameters);

                for (int i = 0; i < dataTable.Rows.Count && i < 4; i++)
                {
                    answers[i] = dataTable.Rows[i]["answer"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving answers: " + ex.Message);
            }

            return answers;
        }


        private string GetSelectedQuestionText()
        {
            if (dataGridView_question.SelectedRows.Count > 0)
            {
                return dataGridView_question.SelectedRows[0].Cells["question_text"].Value.ToString();
            }
            return string.Empty;
        }

        private int GetSelectedQuestionType()
        {
            if (dataGridView_question.SelectedRows.Count > 0)
            {
                var idTypeValue = dataGridView_question.SelectedRows[0].Cells["id_type"].Value;
                if (idTypeValue != null && int.TryParse(idTypeValue.ToString(), out int idType))
                {
                    return idType;
                }
                else
                {
                    MessageBox.Show("Invalid question type data.");
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Please select a question.");
                return -1;
            }
        }

        private string GetSelectedAnswer1() => GetSelectedAnswer(1);
        private string GetSelectedAnswer2() => GetSelectedAnswer(2);
        private string GetSelectedAnswer3() => GetSelectedAnswer(3);
        private string GetSelectedAnswer4() => GetSelectedAnswer(4);

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbb_typequestion.SelectedItem == null)
            {
                MessageBox.Show("Please select a question type.");
                return;
            }

            string selectedType = cbb_typequestion.SelectedItem.ToString();
            string query = "SELECT id FROM type WHERE name = @typeName";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@typeName", selectedType)
            };

            try
            {
                object result = DatabaseHelper.ExecuteScalar(query, parameters);

                if (result != null && int.TryParse(result.ToString(), out int typeId))
                {
                    switch (typeId)
                    {
                        case 1:
                            OpenChildForm(new Question_Multichoice_Add());
                            break;
                        case 2:
                            OpenChildForm(new Question_Open_Add());
                            break;
                        case 3:
                            OpenChildForm(new Question_TF_Add());
                            break;
                        default:
                            MessageBox.Show("Invalid question type.");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid question type.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding question: " + ex.Message);
            }
        }

        private List<string> GetCorrectAnswersForOpenQuestion(int questionId)
        {
            List<string> correctAnswers = new List<string>();
            string query = "SELECT answer FROM answer WHERE id_question = @questionId AND is_correct = 1";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@questionId", questionId)
            };

            try
            {
                DataTable resultTable = DatabaseHelper.ExecuteQuery(query, parameters);

                foreach (DataRow row in resultTable.Rows)
                {
                    correctAnswers.Add(row["answer"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting correct answers for open-ended question: " + ex.Message);
            }

            return correctAnswers;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedQuestionId = GetSelectedQuestionId();
            int questionType = GetSelectedQuestionType();

            if (questionType == 1)
            {
                string questionText = GetSelectedQuestionText();
                string[] answers = GetMultichoiceAnswers();

                var updateForm = new Question_Mutilchoice_update
                {
                    QuestionId = selectedQuestionId,
                    QuestionText = questionText,
                    Answer1 = answers.Length > 0 ? answers[0] : string.Empty,
                    Answer2 = answers.Length > 1 ? answers[1] : string.Empty,
                    Answer3 = answers.Length > 2 ? answers[2] : string.Empty,
                    Answer4 = answers.Length > 3 ? answers[3] : string.Empty
                };
                OpenChildForm(updateForm);
            }
            else if (questionType == 2)
            {
                string questionText = GetSelectedQuestionText();
                List<string> correctAnswers = GetCorrectAnswersForOpenQuestion(selectedQuestionId);

                var updateForm = new Question_Open_update(selectedQuestionId, correctAnswers)
                {
                    QuestionText = questionText
                };
                OpenChildForm(updateForm);
            }
            else if (questionType == 3)
            {
                string questionText = GetSelectedQuestionText();
                string correctAnswer = GetCorrectAnswerForTrueFalse(selectedQuestionId);

                var updateForm = new Question_TF_update(selectedQuestionId, correctAnswer)
                {
                    QuestionText = questionText
                };
                OpenChildForm(updateForm);
            }
            else
            {
                MessageBox.Show("Invalid.");
            }
        }

        private string GetCorrectAnswerForTrueFalse(int questionId)
        {
            string query = "SELECT answer FROM answer WHERE id_question = @questionId AND is_correct = 1 LIMIT 1";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@questionId", questionId)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);

            return result != null ? result.ToString().ToLower() : string.Empty;
        }
    }
}
