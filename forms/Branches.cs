using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITI_APP_TEST
{
    public partial class Branches : Form
    {
        // Connection string to connect to the database
        SqlConnection conn = new SqlConnection(@"Data Source=SARAELDAMARANY;Initial Catalog=Final_Project1;Integrated Security=True");
        string connectionString = "Server=SARAELDAMARANY;Database=Final_Project1;Integrated Security=True";

        public Branches()
        {
            InitializeComponent();
        }

        private void Branches_Load(object sender, EventArgs e)
        {
            LoadBranches(); // Load branch data when the form loads
        }

        private void LoadBranches()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL Query to select all branches
                    string query = "SELECT branch_id, branch_name, location FROM Branch";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind DataTable to DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Branches newForm1 = new Branches();
            this.Visible = false;

            newForm1.Show();


            newForm1.FormClosed += (s, args) =>
            {
                this.Visible = true;
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowStudents newForm1 = new ShowStudents();
            this.Visible = false;

            newForm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddQues form = new AddQues();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
