using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();

        private int licznik = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"sound.wav");
            simpleSound.Play();

            timer1.Start();
            form2.Show();
            form2.FormClosed += new FormClosedEventHandler(duplicate);
            form2.sTOPToolStripMenuItem.Click += new EventHandler(Stop);
        }

        private void Stop(object sender, EventArgs e) {
            password passwordForm = new password();
            passwordForm.ShowDialog();
            if(passwordForm.value == "12345")
            {
                MessageBox.Show("good password", "congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            else
            {
                MessageBox.Show("bad password", "lol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                licznik++;
                for (int i = 0; i < licznik; i++)
                {
                    form2 = new Form2();
                    form2.Show();
                    form2.FormClosed += new FormClosedEventHandler(duplicate);
                    form2.sTOPToolStripMenuItem.Click += new EventHandler(Stop);
                }
            }
            
        }

        private void duplicate(object sender, FormClosedEventArgs e)
        {
            licznik++;
            for (int i = 0; i < licznik; i++)
            {
                form2 = new Form2();
                form2.Show();
                form2.FormClosed += new FormClosedEventHandler(duplicate);
                form2.sTOPToolStripMenuItem.Click += new EventHandler(Stop);
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
        }
    }
}
