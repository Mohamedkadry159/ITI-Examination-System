using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITI_APP_TEST
{
    public partial class ShowStudents : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SARAELDAMARANY;Initial Catalog=Final_Project1;Integrated Security=True");
        string connectionString = "Server=SARAELDAMARANY;Database=Final_Project1;Integrated Security=True";
        private DataTable dt = new DataTable(); 

        public ShowStudents()
        {
            InitializeComponent();
        }

        private void ShowStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT stu_id AS student_id, 
                               CONCAT(stu_fname, ' ', stu_lname) AS full_name, 
                               age, gender,
                               faculty ,address
                        FROM student";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Clear();
                        adapter.Fill(dt);
                        dataGridViewStudents.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
             //   string searchText = txtStudentSearch.Text.Trim().Replace("'", "''"); 

             //   if (string.IsNullOrEmpty(searchText))
                {
                    dataGridViewStudents.DataSource = dt; 
                }
             //   else
                {
                    DataView dv = dt.DefaultView;
               //     dv.RowFilter = $"full_name LIKE '%{searchText}%'";
                    dataGridViewStudents.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddQues form = new AddQues();
            form.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddQues form = new AddQues();
            form.ShowDialog();
        }
    }
}
