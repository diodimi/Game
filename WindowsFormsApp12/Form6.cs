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
    public partial class Form6 : Form
    {
        Boolean rbutton1, rbutton2, rbutton3;
        int timer,rec1,rec2,rec3;
        string user;

        public Form6(Boolean rb1,Boolean rb2, bool rb3,int record1,int record2, int record3, string username)
        {
            InitializeComponent();
            rbutton1 = rb1;
            rbutton2 = rb2;
            rbutton3 = rb3;

            rec1 = record1;
            user = username;
            rec2 = record2;
            rec3 = record3;
        }
        int score = 0;
        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            three.SizeMode = PictureBoxSizeMode.StretchImage;
            two.SizeMode = PictureBoxSizeMode.StretchImage;
            one.SizeMode = PictureBoxSizeMode.StretchImage;
            go.SizeMode = PictureBoxSizeMode.StretchImage;

            gameOver.SizeMode = PictureBoxSizeMode.StretchImage;
            timerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            three.Location = new Point(-9,-25);
            two.Location = new Point(-9, -25);

            gameOver.Location = new Point(-9, -25);
            one.Location = new Point(-9, -25);
            go.Location = new Point(-9, -25);
            piraeteShip.Location = new Point(-9, -25);
            //three.Location = new Point(-9, -25);
            label1.Parent = timerImage;
            label1.BackColor = Color.Transparent;
            var pos = this.PointToScreen(label1.Location);
            pos = timerImage.PointToClient(pos);
            label1.Location = pos;
            label1.Text =score.ToString();
            two.Visible =false;

            gameOver.Visible = false;
            one.Visible = false;
            go.Visible = false;
            piraeteShip.Visible = false;
            if (rbutton1 == true)
            {
                timer1.Interval = 800;
                timer = 800;

            }
            else if (rbutton2 == true)
            {
                timer1.Interval = 650;
                timer = 650;

            }
            else
            {
                timer1.Interval = 550;
                timer = 550;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int top = rnd.Next(30, 350);
            int left = rnd.Next(35, 755);
            piraeteShip.Location = new Point(left, top);


            timer1.Interval = timer;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void three_Click(object sender, EventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {

        }
        int sec = 3;
        private void imagesTimer_Tick(object sender, EventArgs e)
        {
            if (sec == 2)
            {
                two.Visible = true;
                three.Visible = false;
            }
            else if (sec == 1)
            {

                one.Visible = true;
                two.Visible = false;
            }
            else if(sec==0){

                go.Visible = true;
                one.Visible = false;
            }
            else if (sec == -1)
            {

                piraeteShip.Visible = true;
                go.Visible = false;
                timer1.Enabled = true;
                timer2.Enabled = true;
                imagesTimer.Enabled = false;
            }
            sec--;
        }
        
        //Ta defterolepta mexri na teliosei to paixnidi
        int remainingTime = 60;
        bool highScore;
        private void timer2_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            if (remainingTime == 0)
            {
                piraeteShip.Visible = false;
                gameOver.Visible = true;
                if (rbutton1 == true && rec1 <score)
                {
                    MessageBox.Show("asd");
                    rec1 = score;
                    System.IO.StreamReader sr = new System.IO.StreamReader("passwords.txt");

                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] comp = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (comp[0] == user)
                        {



                            sr.Close();
                            string text = File.ReadAllText("passwords.txt");


                            text = text.Replace(line, comp[0] + " " + comp[1] + " " + comp[2] + " " + comp[3] + " " + comp[4] + " " + rec1 + " " + comp[6] + " " + comp[7] + " " + comp[8] + " " + comp[9]);


                            File.WriteAllText("passwords.txt", text);

                            break;
                        }

                        highScore = true;
                    }
                }
                else if (rbutton2 == true && rec2 < score)
                {
                    rec2 =score;
                    System.IO.StreamReader sr = new System.IO.StreamReader("passwords.txt");

                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] comp = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (comp[0] == user)
                        {



                            sr.Close();
                            string text = File.ReadAllText("passwords.txt");


                            text = text.Replace(line, comp[0] + " " + comp[1] + " " + comp[2] + " " + comp[3] + " " + comp[4] + " " + comp[5] + " " + rec2 + " " + comp[7] + " " + comp[8] + " " + comp[9]);


                            File.WriteAllText("passwords.txt", text);

                            break;
                        }

                    }

                    highScore = true;
                }
                else if (rbutton3 == true && rec3 < score)
                {
                    rec3 =score;
                    System.IO.StreamReader sr = new System.IO.StreamReader("passwords.txt");

                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] comp = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (comp[0] == user)
                        {



                            sr.Close();
                            string text = File.ReadAllText("passwords.txt");


                            text = text.Replace(line, comp[0] + " " + comp[1] + " " + comp[2] + " " + comp[3] + " " + comp[4] + " " + comp[5] + " " + comp[6] + " " + rec3 + " " + comp[8] + " " + comp[9]);


                            File.WriteAllText("passwords.txt", text);

                            break;
                        }


                    }

                    highScore = true;
                }
                DialogResult dialogResult;
                if (highScore == true)
                {
                     dialogResult = MessageBox.Show( "Congratulations you made new High Score!\nDo you want to play again?", "", MessageBoxButtons.YesNo);

                }
                else
                {
                     dialogResult = MessageBox.Show( "Do you want to play again?", "", MessageBoxButtons.YesNo);

                }
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    Form6 f6 = new Form6(rbutton1, rbutton2, rbutton3, rec1, rec2, rec3, user);
                    f6.ShowDialog(this);

                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                    Form3 f3 = new Form3(user);
                    f3.ShowDialog(this);


                }
            }
           
        }
            private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //To score otan klikareiw tin eikona
        //Otan klikarei kano to interval toy xronoy emfanisis toy ploio 1 kai epanafero to kanoniko sto epomeno tick
        //oste na allazeii topothesia toy ploioy otan ginetai to click
        private void piraeteShip_Click(object sender, EventArgs e)
        {
            score += 1;
            label1.Text=score.ToString();

            timer1.Interval=1;
        }
    }
}
