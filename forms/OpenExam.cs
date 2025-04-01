using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_APP_TEST
{
    public partial class OpenExam : Form
    {

        private Timer timer;
        private int timeRemaining = 3600;
        public static int finalScore = 0;
        public OpenExam()
        {
            InitializeComponent();
            InitializeCountdown();
            StartTimer();
        }
        private void InitializeCountdown()
        {
            labelTimer.Text = FormatTime(timeRemaining); // Show initial time

            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining--;

            labelTimer.Text = FormatTime(timeRemaining); // Update label

            if (timeRemaining <= 0)
            {
                timer.Stop();
                MessageBox.Show("Time is up! The form will close.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Close the form
            }
        }

        private string FormatTime(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}"; // Format as HH:MM:SS
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int score = 0; 
        private void button1_Click(object sender, EventArgs e)
        {
            // Model Answers
            Dictionary<string, bool> modelAnswers = new Dictionary<string, bool>()
    {
        {"groupBox1", true},
        {"groupBox2", true},
        {"groupBox3", true},
        {"groupBox4", false},
        {"groupBox5", true}
    };

            int score = 0;

            // Loop through each GroupBox inside panel2 (not the form)
            foreach (Control ctrl in panel2.Controls) // Loop inside panel2
            {
                if (ctrl is GroupBox groupBox)
                {
                    if (modelAnswers.ContainsKey(groupBox.Name)) // Ensure GroupBox exists in dictionary
                    {
                        // Find the selected RadioButton
                        RadioButton selectedRb = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

                        if (selectedRb != null) // Ensure a radio button is checked
                        {
                            // Normalize text: remove spaces, ignore case
                            string userAnswerText = selectedRb.Text.Trim();

                            bool userAnswer = userAnswerText.Equals("True", StringComparison.OrdinalIgnoreCase);

                            // Compare with model answer
                            if (userAnswer == modelAnswers[groupBox.Name])
                            {
                                score++;
                            }
                        }
                        else
                        {
                            // Show a warning if a group has no selected radio button
                            MessageBox.Show($"You must select an answer for {groupBox.Text}", "Missing Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            // Show result
           finalScore = score * 10;
            MessageBox.Show($"You answered {score} question(s) out of 5\nYour score: {finalScore}%", "Quiz Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void OpenExam_Load(object sender, EventArgs e)
        {

        }
    }
}
