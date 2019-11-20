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
    public partial class Form2 : Form
    {
        public Form2(List<string> users)
        {
            InitializeComponent();
            user.AddRange(users);
        }
        List<string> user = new List<string>();

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBoxSea.SizeMode = PictureBoxSizeMode.StretchImage;
            
          
            licenseBox.Parent = pictureBoxSea;
            licenseBox.BackColor = Color.Transparent;
            labelUserLogin.Parent = pictureBoxWood;
            labelUserLogin.BackColor = Color.Transparent;
            var pos = this.PointToScreen(labelUserLogin.Location);
            pos = pictureBoxWood.PointToClient(pos);
            labelUserLogin.Location = pos;


            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;



            newsletterBox.Parent = pictureBoxSea;
            newsletterBox.BackColor = Color.Transparent;
            
            
        }

        private void pictureBoxSea_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxWood_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxWood_Click_1(object sender, EventArgs e)
        {

        }

        private void labelUserLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void licenseBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void licenseBox_CheckedChanged_1(object sender, EventArgs e)
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
                textBoxPass.UseSystemPasswordChar = true;

                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.Black;
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

        private void emailText_Enter(object sender, EventArgs e)
        {
            if (emailText.Text == "Email")
            {
                emailText.Text = "";
                emailText.ForeColor = Color.Black;
            }
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            if (emailText.Text == "")
            {
                emailText.Text = "Email";
                emailText.ForeColor = Color.Silver;
            }
        }

        private void ConfirmText_Enter(object sender, EventArgs e)
        {
            if (ConfirmText.Text == "Confirm")
            {
                ConfirmText.Text = "";
                ConfirmText.ForeColor = Color.Black;
                ConfirmText.UseSystemPasswordChar = true;

            }
        }

        private void ConfirmText_Leave(object sender, EventArgs e)
        {
            if (ConfirmText.Text == "")
            {
                ConfirmText.Text = "Confirm";
                ConfirmText.ForeColor = Color.Silver;
                ConfirmText.UseSystemPasswordChar = false;

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


        private void button1_Click(object sender, EventArgs e)
        {


            string errorMess ="";
            if (emailText.Text == "Email")
            {
                errorMess += "•Email\r\n";
                
            }
            if (firNameTextbox.Text == "First Name")
            {
                errorMess += "•First Name\r\n";

            }
            if (lastNameTextbox.Text == "Last Name")
            {
                errorMess += "•Last Name\r\n";

            }
            if (textBoxUsername.Text == "Username")
            {
                errorMess += "•Username\r\n";
            }
            if(textBoxPass.Text == "Password")
            {
                errorMess += "•Password\r\n";
            }
            if (ConfirmText.Text == "Confirm")
            {
                errorMess += "•Confirm Password\r\n";
            }

            if (errorMess != "")
            {
                MessageBox.Show("You must complete: \r\n"+errorMess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPass.Text != ConfirmText.Text)
            {
                MessageBox.Show("The passwords are different!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPass.Text = "";
                ConfirmText.Text = "";
            }
            else if (user.Contains(textBoxUsername.Text))
            {
                MessageBox.Show("The username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxUsername.Text.Length >= 8)
            {
                MessageBox.Show("The username must contain up to 8 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBoxPass.Text.Length < 5)
            {
                MessageBox.Show("The username must contain at least 5 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (licenseBox.Checked == false)
            {
                MessageBox.Show("You must accept licence!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                licenseBox.BackColor = Color.Red;

            }
            else
            {
                using (StreamWriter sw = new StreamWriter("passwords.txt", append: true))
                {
                    sw.WriteLine(textBoxUsername.Text + " " + textBoxPass.Text+" "+firNameTextbox.Text + " "+lastNameTextbox.Text + " "+emailText.Text + " "+"0"+" " + "0" + " " +"0"+" "+ DateTime.Now.ToString("MM/dd/yyyy")+" "+"-");
                    MessageBox.Show("You have succesfully created account!");
                    sw.Close();
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog(this);

                }
            }

        }

        private void licenseBox_Validated(object sender, EventArgs e)
        {
            
        }

        private void licenseBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (licenseBox.BackColor == Color.Red)
            {
                licenseBox.BackColor = Color.Transparent;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void firNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firNameTextbox_Enter(object sender, EventArgs e)
        {
            if (firNameTextbox.Text == "First Name")
            {
                firNameTextbox.Text = "";
                firNameTextbox.ForeColor = Color.Black;
            }
        }

        private void lastNameTextbox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextbox.Text == "Last Name")
            {
                lastNameTextbox.Text = "";
                lastNameTextbox.ForeColor = Color.Black;
            }
        }

        private void firNameTextbox_Leave(object sender, EventArgs e)
        {
            if (firNameTextbox.Text == "")
            {
                firNameTextbox.Text = "First Name";
                firNameTextbox.ForeColor = Color.Silver;
            }
        }
    }
}
