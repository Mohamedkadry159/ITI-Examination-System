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
    public partial class SplashForm : Form
    {
        private Timer timer;

        public SplashForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove window borders
            this.StartPosition = FormStartPosition.CenterScreen; // Center screen
            this.TopMost = true; // Ensure it appears on top

            // Initialize Timer
            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer.Start(); // Start timer when form loads
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Stop the timer
            this.Close(); // Close splash screen
        }
    }
}