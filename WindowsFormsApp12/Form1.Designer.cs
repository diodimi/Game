namespace WindowsFormsApp12
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSea = new System.Windows.Forms.PictureBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.pictureBoxWood = new System.Windows.Forms.PictureBox();
            this.pictureBoxPirate = new System.Windows.Forms.PictureBox();
            this.pictureBoxkey = new System.Windows.Forms.PictureBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPirate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxkey)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pictureBoxSea
            // 
            this.pictureBoxSea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSea.Image")));
            this.pictureBoxSea.Location = new System.Drawing.Point(-4, 0);
            this.pictureBoxSea.Name = "pictureBoxSea";
            this.pictureBoxSea.Size = new System.Drawing.Size(809, 453);
            this.pictureBoxSea.TabIndex = 2;
            this.pictureBoxSea.TabStop = false;
            this.pictureBoxSea.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelUserLogin.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelUserLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserLogin.Location = new System.Drawing.Point(265, 4);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(244, 50);
            this.labelUserLogin.TabIndex = 5;
            this.labelUserLogin.Text = "USER LOGIN";
            this.labelUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBoxWood
            // 
            this.pictureBoxWood.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWood.Image")));
            this.pictureBoxWood.Location = new System.Drawing.Point(224, 0);
            this.pictureBoxWood.Name = "pictureBoxWood";
            this.pictureBoxWood.Size = new System.Drawing.Size(317, 57);
            this.pictureBoxWood.TabIndex = 3;
            this.pictureBoxWood.TabStop = false;
            this.pictureBoxWood.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxPirate
            // 
            this.pictureBoxPirate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPirate.Image")));
            this.pictureBoxPirate.Location = new System.Drawing.Point(242, 190);
            this.pictureBoxPirate.Name = "pictureBoxPirate";
            this.pictureBoxPirate.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPirate.TabIndex = 6;
            this.pictureBoxPirate.TabStop = false;
            this.pictureBoxPirate.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBoxkey
            // 
            this.pictureBoxkey.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxkey.Image")));
            this.pictureBoxkey.Location = new System.Drawing.Point(242, 255);
            this.pictureBoxkey.Name = "pictureBoxkey";
            this.pictureBoxkey.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxkey.TabIndex = 7;
            this.pictureBoxkey.TabStop = false;
            this.pictureBoxkey.Click += new System.EventHandler(this.pictureBoxkey_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxPass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPass.Location = new System.Drawing.Point(301, 255);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(25, 15, 15, 15);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(200, 40);
            this.textBoxPass.TabIndex = 10;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxUsername.Location = new System.Drawing.Point(301, 190);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(25, 15, 15, 15);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 40);
            this.textBoxUsername.TabIndex = 10;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.linkLabelSignUp.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabelSignUp.Location = new System.Drawing.Point(298, 344);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(147, 18);
            this.linkLabelSignUp.TabIndex = 11;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "New Pirate? Sign Up!";
            this.linkLabelSignUp.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(301, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.pictureBoxkey);
            this.Controls.Add(this.pictureBoxPirate);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.pictureBoxWood);
            this.Controls.Add(this.pictureBoxSea);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPirate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxkey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSea;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.PictureBox pictureBoxWood;
        private System.Windows.Forms.PictureBox pictureBoxPirate;
        private System.Windows.Forms.PictureBox pictureBoxkey;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.Button button1;
    }
}

