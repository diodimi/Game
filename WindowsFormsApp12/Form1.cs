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
    public partial class Form1 : Form
    {
        public object Streamreader { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        List<string> users = new List<string>();
        List<string> passwords = new List<string>();
        List<int> highScore = new List<int>();


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxSea.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWood.SizeMode = PictureBoxSizeMode.StretchImage;
            labelUserLogin.Parent = pictureBoxWood;
            labelUserLogin.BackColor = Color.Transparent;
            var pos = this.PointToScreen(labelUserLogin.Location);
            pos = pictureBoxWood.PointToClient(pos);
            labelUserLogin.Location = pos;

            pictureBoxPirate.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPirate.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxkey.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxkey.SizeMode = PictureBoxSizeMode.StretchImage;

            linkLabelSignUp.Parent = pictureBoxSea;
            linkLabelSignUp.BackColor = Color.Transparent;
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            StreamReader sr = new StreamReader("passwords.txt");
            string line = "";
            while ((line=sr.ReadLine())!=null)
            {
                string[] comp = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(comp[0]);
                passwords.Add(comp[1]);
            }
            sr.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Password")
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.Black;
                textBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Silver;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "Password";
                textBoxPass.ForeColor = Color.Silver;
                textBoxPass.UseSystemPasswordChar = false;

            }
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(users);
            f2.ShowDialog(this);
            linkLabelSignUp.LinkVisited = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //O kodikos prepei na isoytai me ton kodiko poy vrsiketai stin antistoixi thesi poy vrisketai kai toy xristi

            if (users.Contains(textBoxUsername.Text) && passwords.Contains(textBoxPass.Text) && textBoxPass.Text ==  passwords[Array.IndexOf(users.ToArray(), textBoxUsername.Text)])
            {

                Form3 f3 = new Form3(textBoxUsername.Text);
                f3.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Password or username is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pictureBoxkey_Click(object sender, EventArgs e)
        {

        }
    }
}
