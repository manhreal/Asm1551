using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp2
{
    public partial class Admin : Form
    {
        public List<Question> questionBank = new List<Question>();

        public Admin(List<Question> questionBank)
        {
            InitializeComponent();
            this.questionBank = questionBank;
        }

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
        private void bt_add_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox_TypeQ.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedType))
            {
                MessageBox.Show("Please select a question type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (selectedType)
            {
                case "Multi Choice":
                    Q_MultiChoice multiChoiceForm = new Q_MultiChoice(questionBank);
                    OpenChildForm(multiChoiceForm);
                    break;

                case "Open Ended":
                    Q_OpenEnded openEndedForm = new Q_OpenEnded(questionBank);
                    OpenChildForm(openEndedForm);
                    break;

                case "True False":
                    Q_TrueFalse trueFalseForm = new Q_TrueFalse(questionBank);
                    OpenChildForm (trueFalseForm);
                    break;

                default:
                    MessageBox.Show("Invalid question type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            ReloadQuestions();
        }
        private void ReloadQuestions()
        {
            if (rt_all.InvokeRequired)
            {
                rt_all.Invoke(new Action(ReloadQuestions));
                return;
            }

            try
            {
                rt_all.Clear();

                Console.WriteLine($"Total questions: {questionBank.Count}");
                if (questionBank.Count == 0)
                {
                    rt_all.Text = "No questions in the question bank.";
                    return;
                }

                for (int i = 0; i < questionBank.Count; i++)
                {
                    var question = questionBank[i];
                    rt_all.AppendText($"i = {i}:\n");

                    if (question is MultipleChoiceQuestion mcq)
                    {
                        rt_all.AppendText($"Question: {mcq.QuestionText}\n");
                        rt_all.AppendText("Answer:\n");
                        for (int j = 0; j < mcq.Options.Length; j++)
                        {
                            rt_all.AppendText($"{j + 1}. {mcq.Options[j]}\n");
                        }

                        rt_all.AppendText($"Correct: {mcq.GetCorrectAnswer()}\n\n");
                    }
                    else if (question is OpenEndedQuestion oeq)
                    {
                        rt_all.AppendText($"Question: {oeq.QuestionText}\n");
                        rt_all.AppendText("Answer:\n");
                        foreach (var answer in oeq.CorrectAnswers)
                        {
                            rt_all.AppendText($"{answer}\n");
                        }
                        rt_all.AppendText("\n");
                    }
                    else if (question is TrueFalseQuestion tfq)
                    {
                        rt_all.AppendText($"Question: {tfq.QuestionText}\n");
                        string correctAnswer = tfq.CorrectAnswer ? "True" : "False";
                        rt_all.AppendText($"Correct: {correctAnswer}\n\n");
                    }
                    rt_all.AppendText("---------------------------------------\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_displayall_Click(object sender, EventArgs e)
        {
            ReloadQuestions();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tb_index.Text, out int index))
                {
                    MessageBox.Show("Please enter a valid index number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (index < 0 || index >= questionBank.Count)
                {
                    MessageBox.Show("Invalid index. Please enter a valid index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Question selectedQuestion = questionBank[index];

                if (selectedQuestion is MultipleChoiceQuestion multiChoiceQuestion)
                {
                    Q_MultiChoice_Edit multiChoiceEditForm = new Q_MultiChoice_Edit(multiChoiceQuestion);
                    OpenChildForm(multiChoiceEditForm);
                    ReloadQuestions();
                }
                else if (selectedQuestion is OpenEndedQuestion openEndedQuestion)
                {
                    Q_OpenEnded_Edit openEndedEditForm = new Q_OpenEnded_Edit(openEndedQuestion);
                    OpenChildForm(openEndedEditForm);
                    ReloadQuestions();
                }
                else if (selectedQuestion is TrueFalseQuestion trueFalseQuestion)
                {
                     Q_TrueFalse_Edit trueFalseEditForm = new Q_TrueFalse_Edit(trueFalseQuestion);
                    OpenChildForm(trueFalseEditForm);
                    ReloadQuestions();
                }
                else
                {
                    MessageBox.Show("Unknown question type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(tb_index.Text, out int index))
                {
                    MessageBox.Show("Please enter a valid index number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (index < 0 || index >= questionBank.Count)
                {
                    MessageBox.Show("Invalid index. Please enter a valid index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Question questionToDelete = questionBank[index];

                string questionPreview = questionToDelete.QuestionText;
                if (questionToDelete is MultipleChoiceQuestion mcq)
                {
                    questionPreview += "\nChoices:\n";
                    for (int i = 0; i < mcq.Options.Length; i++)
                    {
                        questionPreview += $"  {i + 1}. {mcq.Options[i]}\n";
                    }
                }
                else if (questionToDelete is OpenEndedQuestion oeq)
                {
                    questionPreview += "\nPossible Correct Answers:\n";
                    foreach (var answer in oeq.CorrectAnswers)
                    {
                        questionPreview += $"  - {answer}\n";
                    }
                }
                else if (questionToDelete is TrueFalseQuestion tfq)
                {
                    string correctAnswer = tfq.CorrectAnswer ? "True" : "False";
                    questionPreview += $"\nCorrect Answer: {correctAnswer}";
                }

                DialogResult dialogResult = MessageBox.Show(
                    $"Are you sure you want to delete the following question?\n\n{questionPreview}",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    questionBank.RemoveAt(index);
                    MessageBox.Show("Question deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadQuestions();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid index number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
