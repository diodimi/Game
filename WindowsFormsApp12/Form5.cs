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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        List<string> users1 = new List<string>();
        List<string> users2 = new List<string>();
        List<string> users3 = new List<string>();
        List<int> rec1 = new List<int>();
        List<int> rec2 = new List<int>();
        List<int> rec3 = new List<int>();


        private void Form5_Load(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;

            System.IO.StreamReader sr = new StreamReader("passwords.txt");
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox2.PointToClient(pos);
            label1.Location = pos;
            pos = this.PointToScreen(label2.Location);
            pos = pictureBox2.PointToClient(pos);
            label2.Location = pos;
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] comp = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                users1.Add(comp[0]);
                users2.Add(comp[0]);
                users3.Add(comp[0]);

                rec1.Add(Int32.Parse(comp[5]));

                rec2.Add(Int32.Parse(comp[6]));

                rec3.Add(Int32.Parse(comp[7]));

            }
            sr.Close();
            for(int i = 0; i < users1.Count; i++)
            {
                for(int j = i + 1; j < users1.Count; j++)
                {
                    if (rec1[i] < rec1[j])
                    {
                        int temp = rec1[i];
                        rec1[i] = rec1[j];
                        rec1[j] = temp;
                        string ustemp = users1[i];
                        users1[i] = users1[j];
                        users1[j] = ustemp;
                    }
                    if (rec2[i] < rec2[j])
                    {
                        int temp = rec2[i];
                        rec2[i] = rec2[j];
                        rec2[j] = temp;
                        string ustemp = users2[i];
                        users2[i] = users2[j];
                        users2[j] = ustemp;
                    }
                    if (rec3[i] < rec3[j])
                    {
                        int temp = rec3[i];
                        rec3[i] = rec3[j];
                        rec3[j] = temp;
                        string ustemp = users3[i];
                        users3[i] = users3[j];
                        users3[j] = ustemp;
                    }
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text =" Username";
            label2.Text = "High Score";
            label1.Text += "\n";
            label2.Text += "\n";
            for (int i = 0; i < users1.Count; i++)
            {
                label1.Text += (i + 1).ToString() + ". " + " " + users1[i] + "\n";
                
                label2.Text +="        "+ rec1[i]+"\n";
            }
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " Username";
            label2.Text = "High Score";
            label1.Text += "\n";
            label2.Text += "\n";
            for (int i = 0; i < users2.Count; i++)
            {
                label1.Text += (i + 1).ToString() + ". " + " " + users2[i] + "\n";

                label2.Text += "        " + rec2[i] + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = " Username";
            label2.Text = "High Score";
            label1.Text += "\n";
            label2.Text += "\n";
            for (int i = 0; i < users3.Count; i++)
            {
                label1.Text += (i + 1).ToString() + ". " + " " + users3[i] + "\n";

                label2.Text += "        " + rec3[i] + "\n";
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
