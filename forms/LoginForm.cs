using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITI_APP_TEST
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=SARAELDAMARANY;Initial Catalog=Final_Project1;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string LoggedInUserEmail;


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '●')
            {
                txt_password.PasswordChar = '\0';
                pictureBox2.Image = eyepic.Image;

            }
            else
            {
                txt_password.PasswordChar = '●';
                pictureBox2.Image = swpic.Image;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            String username, user_password,role;

            username = txt_username.Text;
            user_password = txt_password.Text;
            role = roleBox.Text;

            try
            {
                string query = "SELECT * FROM users WHERE Email = '" + txt_username.Text +
               "' AND password = '" + txt_password.Text +
               "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;
                    role = roleBox.Text;
                    LoggedInUserEmail = txt_username.Text;
                   
                    if (role == "Student")
                    {

                     StudentExams form1 = new StudentExams();
                     form1.Show();
                    this.Visible=false;
                    form1.FormClosed += (s, args) =>
                    {
                        this.Visible = true;
                    };
                        this.Hide();
                    }
                    else
                    {
                        InstructorProfile form1 = new InstructorProfile();
                        form1.Show();
                        this.Visible = false;
                        form1.FormClosed += (s, args) =>
                        {
                            this.Visible = true;
                        };
                        this.Hide();
                    }
                }
                    else
                {
                    MessageBox.Show("Invalid login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                   // roleBox.Items.Clear();

                    txt_username.Focus();
                }


            }
            catch
            {
                MessageBox.Show("Error, Please try again...");
            }
            finally 
            {
            conn.Close();   
            }


        }

        private void LoginForm_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           TakeExam form = new TakeExam();
            form.ShowDialog();
        }
    }
}
