using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool timer = false;

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.BackColor = Color.Red;
            panel1.BackgroundImage = Properties.Resources.troll1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer)
            {
                panel1.BackColor = Color.Red;
                panel1.BackgroundImage = Properties.Resources.troll1;
                timer = false;
            }
            else
            {
                panel1.BackColor = Color.Yellow;
                panel1.BackgroundImage = Properties.Resources.troll2;
                timer = true;
            }
        }

        private void sTOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
