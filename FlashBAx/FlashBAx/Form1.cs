using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashBAx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button != MouseButtons.Left) return;
            {
               int X = this.Left - MousePosition.X;
               int Y = this.Top - MousePosition.Y;

            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                int X = 0;
                this.Left = X + MousePosition.X;
                int Y = 0;
                this.Top = Y + MousePosition.Y;

            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        { 

        }
    }
}
