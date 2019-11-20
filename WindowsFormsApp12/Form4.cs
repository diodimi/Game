using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form4 : Form
    {
        string username;
        public Form4(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            groupBox1.Parent = pictureBox2;
            groupBox1.BackColor = Color.Transparent;
            var pos = this.PointToScreen(groupBox1.Location);
            pos = pictureBox2.PointToClient(pos);
            groupBox1.Location = pos;
            StreamReader sr = new StreamReader("passwords.txt");

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] comp = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (comp[0] == username)
                {
                    label2.Text += "  " + comp[2];
                    label3.Text += "  " + comp[3];
                    label4.Text += "  " + comp[4];

                    label5.Text += "  " + comp[5];
                    label6.Text += "  " + comp[6];
                    label7.Text += "  " + comp[7];
                    label8.Text += "  " + comp[8];
                    label9.Text += "  " + comp[9];
                    break;
                }
            }
            sr.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
