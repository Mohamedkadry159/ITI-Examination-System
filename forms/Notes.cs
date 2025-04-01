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
    public partial class Notes : Form
    {

        Pen pen = new Pen(Color.Black, 5);
        public Notes()
        {
            InitializeComponent();
        }

        private void lineColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += textBox1.Text + '\n';
            //  labelText += label1.Text;
            textBox1.Clear();
        }

        private void lineColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            pen = new Pen(cd.Color, 10);
            lineColor.BackColor = cd.Color;
            label1.ForeColor = cd.Color;
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }
    }
}
