namespace WindowsFormsApp12
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.piraeteShip = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerImage = new System.Windows.Forms.PictureBox();
            this.three = new System.Windows.Forms.PictureBox();
            this.two = new System.Windows.Forms.PictureBox();
            this.one = new System.Windows.Forms.PictureBox();
            this.go = new System.Windows.Forms.PictureBox();
            this.imagesTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piraeteShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // piraeteShip
            // 
            this.piraeteShip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piraeteShip.BackgroundImage")));
            this.piraeteShip.Location = new System.Drawing.Point(433, 207);
            this.piraeteShip.Name = "piraeteShip";
            this.piraeteShip.Size = new System.Drawing.Size(70, 71);
            this.piraeteShip.TabIndex = 1;
            this.piraeteShip.TabStop = false;
            this.piraeteShip.Click += new System.EventHandler(this.piraeteShip_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 489);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerImage
            // 
            this.timerImage.Image = ((System.Drawing.Image)(resources.GetObject("timerImage.Image")));
            this.timerImage.Location = new System.Drawing.Point(334, 0);
            this.timerImage.Name = "timerImage";
            this.timerImage.Size = new System.Drawing.Size(100, 88);
            this.timerImage.TabIndex = 2;
            this.timerImage.TabStop = false;
            this.timerImage.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // three
            // 
            this.three.Image = ((System.Drawing.Image)(resources.GetObject("three.Image")));
            this.three.Location = new System.Drawing.Point(-132, 284);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(816, 489);
            this.three.TabIndex = 3;
            this.three.TabStop = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Image = ((System.Drawing.Image)(resources.GetObject("two.Image")));
            this.two.Location = new System.Drawing.Point(-651, 249);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(816, 489);
            this.two.TabIndex = 4;
            this.two.TabStop = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Image = ((System.Drawing.Image)(resources.GetObject("one.Image")));
            this.one.Location = new System.Drawing.Point(241, 367);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(816, 489);
            this.one.TabIndex = 5;
            this.one.TabStop = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // go
            // 
            this.go.Image = ((System.Drawing.Image)(resources.GetObject("go.Image")));
            this.go.Location = new System.Drawing.Point(-621, 276);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(816, 489);
            this.go.TabIndex = 6;
            this.go.TabStop = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // imagesTimer
            // 
            this.imagesTimer.Enabled = true;
            this.imagesTimer.Interval = 1000;
            this.imagesTimer.Tick += new System.EventHandler(this.imagesTimer_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(345, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameOver
            // 
            this.gameOver.Image = ((System.Drawing.Image)(resources.GetObject("gameOver.Image")));
            this.gameOver.Location = new System.Drawing.Point(220, 259);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(816, 489);
            this.gameOver.TabIndex = 9;
            this.gameOver.TabStop = false;
            this.gameOver.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.go);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.timerImage);
            this.Controls.Add(this.piraeteShip);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piraeteShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox piraeteShip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox timerImage;
        private System.Windows.Forms.PictureBox three;
        private System.Windows.Forms.PictureBox two;
        private System.Windows.Forms.PictureBox one;
        private System.Windows.Forms.PictureBox go;
        private System.Windows.Forms.Timer imagesTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gameOver;
    }
}