using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_APP_TEST
{
    public partial class AddQues : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SARAELDAMARANY;Initial Catalog=Final_Project1;Integrated Security=True");
        string connectionString = "Server=SARAELDAMARANY;Database=Final_Project1;Integrated Security=True";

        public AddQues()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT course_id, Name FROM course", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<KeyValuePair<int, string>> courses = new List<KeyValuePair<int, string>>();

                    while (reader.Read())
                    {
                        courses.Add(new KeyValuePair<int, string>(
                            Convert.ToInt32(reader["course_id"]),
                            reader["Name"].ToString()
                        ));
                    }

                    reader.Close();

               
                    comboBox1.DataSource = courses;
                    comboBox1.DisplayMember = "Value";  
                    comboBox1.ValueMember = "Key";      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ,while loading courses..: " + ex.Message);
            }
        }

        private void AddQues_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text) ||
                comboBox2.SelectedItem == null || string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Warning , all Data Needed to add Question....");
                return;
            }

            int courseId = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
            string question = textBox1.Text;
            string type = comboBox2.SelectedItem.ToString();
            string modelAnswer = textBox3.Text;
            string[] choices = { textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text };

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

              
                    string getLastQuestionIdQuery = "SELECT ISNULL(MAX(Question_ID), 111) FROM Question";
                    SqlCommand cmdLastQID = new SqlCommand(getLastQuestionIdQuery, conn);
                    int newQuestionId = (int)cmdLastQID.ExecuteScalar() + 1;

       
                    string getLastChoiceIdQuery = "SELECT ISNULL(MAX(Choice_ID), 278) FROM Choices";
                    SqlCommand cmdLastChoiceID = new SqlCommand(getLastChoiceIdQuery, conn);
                    int newChoiceId = (int)cmdLastChoiceID.ExecuteScalar() + 1;

                
                    string insertQuestionQuery = "INSERT INTO Question (Question_ID, course_id, Question_Type, Question, Question_ModelAnswer) VALUES (@QuestionId, @course_id, @type, @question, @modelAnswer);";
                    using (SqlCommand cmdInsertQuestion = new SqlCommand(insertQuestionQuery, conn))
                    {
                        cmdInsertQuestion.Parameters.AddWithValue("@QuestionId", newQuestionId);
                        cmdInsertQuestion.Parameters.AddWithValue("@course_id", courseId);
                        cmdInsertQuestion.Parameters.AddWithValue("@type", type);
                        cmdInsertQuestion.Parameters.AddWithValue("@question", question);
                        cmdInsertQuestion.Parameters.AddWithValue("@modelAnswer", modelAnswer);
                        cmdInsertQuestion.ExecuteNonQuery();
                    }

                   
                    string insertChoiceQuery = "INSERT INTO Choices (Choice_ID, Question_ID, Choice) VALUES (@ChoiceId, @QuestionId, @Choice);";
                    foreach (string choice in choices)
                    {
                        using (SqlCommand cmdInsertChoice = new SqlCommand(insertChoiceQuery, conn))
                        {
                            cmdInsertChoice.Parameters.AddWithValue("@ChoiceId", newChoiceId);
                            cmdInsertChoice.Parameters.AddWithValue("@QuestionId", newQuestionId);
                            cmdInsertChoice.Parameters.AddWithValue("@Choice", choice);
                            cmdInsertChoice.ExecuteNonQuery();
                        }
                        newChoiceId++; 
                    }

             
                    newChoiceId += 4 - choices.Length;

                    MessageBox.Show($"✅ Done , Question Num  {newQuestionId} Successfully added ,and 4 Choices (ID from {newChoiceId - 4} to {newChoiceId - 1}) ....✅");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error : " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

