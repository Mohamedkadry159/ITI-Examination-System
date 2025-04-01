using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_APP_TEST
{
    public partial class InstructorProfile : Form
    {
        public InstructorProfile()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void InstructorProfile_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
           // SetExam newForm1 = new SetExam();
            //this.Visible = false;

//            newForm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddQues form = new AddQues();
            form.ShowDialog();
        }
     
        private void InstructorProfile_Load_Video(object sender, EventArgs e)
        {
            // Set the video path (change this to your actual video file path)
          //  axWindowsMediaPlayer1.URL = @"C:\Users\Sara\Videos\ITI\ITI_EXAM.mp4";
            //axWindowsMediaPlayer1.Ctlcontrols.play(); // Start playing the video
        }

        //private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        //{
        //    string videoPath = @"C:\Users\Sara\Videos\ITI\ITI_EXAM.mp4";
        //    if (System.IO.File.Exists(videoPath))
        //    {
        //        axWindowsMediaPlayer1.URL = videoPath;
        //        axWindowsMediaPlayer1.Ctlcontrols.play(); // Start playing the video
        //        axWindowsMediaPlayer1.settings.autoStart = true;  // Ensure video plays automatically
        //    }
        //    else
        //    {
        //        MessageBox.Show("Video file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


    }
}
