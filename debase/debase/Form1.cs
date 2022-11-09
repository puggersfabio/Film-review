using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = 579;
            panel1.Width = 955;
            panel1.Location = new Point(0,0);
            reviewpage l = new reviewpage();
            panel1.Controls.Add(l);
        }

        private void reviewpage1_Load(object sender, EventArgs e)
        {

        }
    }
}
