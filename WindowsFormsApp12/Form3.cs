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
    public partial class Form3 : Form
    {
        string record1, record2, record3;
        string username;
        public Form3(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            pictureBoxBoat.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            var pos = this.PointToScreen(label2.Location);
            pos = pictureBox2.PointToClient(pos);
            label2.Location = pos;


            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
            pos = this.PointToScreen(label3.Location);
            pos = pictureBox2.PointToClient(pos);
            label3.Location = pos;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Text = "Welcome " + username + "!";

            groupBox1.Parent = pictureBox3;
            groupBox1.BackColor = Color.Transparent;
            pos = this.PointToScreen(groupBox1.Location);
            pos = pictureBox3.PointToClient(pos);
            groupBox1.Location = pos;

            // button1.TabStop = false;
            //button1.FlatStyle = FlatStyle.Flat;
            //button1.FlatAppearance.BorderSize = 0;



            linkLabel1.Parent = pictureBox1;
            linkLabel1.BackColor = Color.Transparent;

            linkLabel2.Parent = pictureBox1;
            linkLabel2.BackColor = Color.Transparent;

            linkLabel3.Parent = pictureBox1;
            linkLabel3.BackColor = Color.Transparent;
            StreamReader sr = new StreamReader("passwords.txt");

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] comp = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (comp[0] == username)
                {
                    record1 = comp[5];
                    record2 = comp[6];
                    record3 = comp[7];
                    break;
                }
            }
            sr.Close();
            if (radioButton1.Enabled)
            {
                label3.Text = record1;
            }
            else if (radioButton2.Enabled)
            {
                label3.Text = record2;

            }
            else if (radioButton3.Enabled)
            {
                label3.Text = record3;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog(this);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxBoat_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form4 f4 = new Form4(username);
            f4.ShowDialog(this);

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamReader sr = new StreamReader("passwords.txt");

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] comp = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (comp[0] == username)
                {



                    sr.Close();
                    string text = File.ReadAllText("passwords.txt");

                    
                    text = text.Replace(line,comp[0]+" "+comp[1] + " " + comp[2] + " " + comp[3] + " " + comp[4] + " " + comp[5] + " " + comp[6] + " " + comp[7] + " " + comp[8]+ " " + DateTime.Now.ToString("MM/dd/yyyy"));

                    
                    File.WriteAllText("passwords.txt", text);

                    break;
                }
            }
        

        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form6 f6 = new Form6(radioButton1.Checked,radioButton2.Checked,radioButton3.Checked,Int32.Parse(record1), Int32.Parse(record2), Int32.Parse(record3),username);
            f6.ShowDialog(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
