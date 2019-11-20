namespace WindowsFormsApp12
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBoxSea = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.ConfirmText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.newsletterBox = new System.Windows.Forms.CheckBox();
            this.licenseBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxWood = new System.Windows.Forms.PictureBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.firNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSea
            // 
            this.pictureBoxSea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSea.Image")));
            this.pictureBoxSea.Location = new System.Drawing.Point(-4, -1);
            this.pictureBoxSea.Name = "pictureBoxSea";
            this.pictureBoxSea.Size = new System.Drawing.Size(809, 453);
            this.pictureBoxSea.TabIndex = 3;
            this.pictureBoxSea.TabStop = false;
            this.pictureBoxSea.Click += new System.EventHandler(this.pictureBoxSea_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxUsername.Location = new System.Drawing.Point(191, 218);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(25, 15, 15, 15);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 40);
            this.textBoxUsername.TabIndex = 11;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxPass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPass.Location = new System.Drawing.Point(191, 279);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(25, 15, 15, 15);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(200, 40);
            this.textBoxPass.TabIndex = 12;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // ConfirmText
            // 
            this.ConfirmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ConfirmText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ConfirmText.Location = new System.Drawing.Point(412, 279);
            this.ConfirmText.Margin = new System.Windows.Forms.Padding(25, 15, 15, 15);
            this.ConfirmText.Name = "ConfirmText";
            this.ConfirmText.Size = new System.Drawing.Size(200, 40);
            this.ConfirmText.TabIndex = 16;
            this.ConfirmText.Text = "Confirm";
            this.ConfirmText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ConfirmText.Enter += new System.EventHandler(this.ConfirmText_Enter);
            this.ConfirmText.Leave += new System.EventHandler(this.ConfirmText_Leave);
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailText.Location = new System.Drawing.Point(412, 219);
            this.emailText.Margin = new System.Windows.Forms.Padding(25, 15, 15, 15);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(200, 40);
            this.emailText.TabIndex = 17;
            this.emailText.Text = "Email";
            this.emailText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.emailText.Enter += new System.EventHandler(this.emailText_Enter);
            this.emailText.Leave += new System.EventHandler(this.emailText_Leave);
            // 
            // newsletterBox
            // 
            this.newsletterBox.AutoSize = true;
            this.newsletterBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newsletterBox.Location = new System.Drawing.Point(191, 337);
            this.newsletterBox.Name = "newsletterBox";
            this.newsletterBox.Size = new System.Drawing.Size(241, 17);
            this.newsletterBox.TabIndex = 18;
            this.newsletterBox.Text = "Keep me up to date on new games and apps.";
            this.newsletterBox.UseVisualStyleBackColor = true;
            this.newsletterBox.CheckedChanged += new System.EventHandler(this.licenseBox_CheckedChanged);
            // 
            // licenseBox
            // 
            this.licenseBox.AutoSize = true;
            this.licenseBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.licenseBox.Location = new System.Drawing.Point(191, 369);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.Size = new System.Drawing.Size(227, 17);
            this.licenseBox.TabIndex = 19;
            this.licenseBox.Text = "I accept the term in the license agreement.";
            this.licenseBox.UseVisualStyleBackColor = true;
            this.licenseBox.CheckedChanged += new System.EventHandler(this.licenseBox_CheckedChanged_1);
            this.licenseBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.licenseBox_MouseClick);
            this.licenseBox.Validated += new System.EventHandler(this.licenseBox_Validated);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(438, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 49);
            this.button1.TabIndex = 20;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxWood
            // 
            this.pictureBoxWood.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWood.Image")));
            this.pictureBoxWood.Location = new System.Drawing.Point(222, -1);
            this.pictureBoxWood.Name = "pictureBoxWood";
            this.pictureBoxWood.Size = new System.Drawing.Size(335, 57);
            this.pictureBoxWood.TabIndex = 21;
            this.pictureBoxWood.TabStop = false;
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelUserLogin.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelUserLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserLogin.Location = new System.Drawing.Point(252, 6);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(274, 50);
            this.labelUserLogin.TabIndex = 22;
            this.labelUserLogin.Text = "Create Account";
            this.labelUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firNameTextbox
            // 
            this.firNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firNameTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.firNameTextbox.Location = new System.Drawing.Point(191, 162);
            this.firNameTextbox.Margin = new System.Windows.Forms.Padding(25, 15, 15, 15);
            this.firNameTextbox.Name = "firNameTextbox";
            this.firNameTextbox.Size = new System.Drawing.Size(200, 40);
            this.firNameTextbox.TabIndex = 23;
            this.firNameTextbox.Text = "First Name";
            this.firNameTextbox.TextChanged += new System.EventHandler(this.firNameTextbox_TextChanged);
            this.firNameTextbox.Enter += new System.EventHandler(this.firNameTextbox_Enter);
            this.firNameTextbox.Leave += new System.EventHandler(this.firNameTextbox_Leave);
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastNameTextbox.Location = new System.Drawing.Point(411, 163);
            this.lastNameTextbox.Margin = new System.Windows.Forms.Padding(25, 15, 15, 15);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(200, 40);
            this.lastNameTextbox.TabIndex = 24;
            this.lastNameTextbox.Text = "Last Name";
            this.lastNameTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            this.lastNameTextbox.Enter += new System.EventHandler(this.lastNameTextbox_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firNameTextbox);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.pictureBoxWood);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.newsletterBox);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.ConfirmText);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.pictureBoxSea);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSea;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox ConfirmText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.CheckBox newsletterBox;
        private System.Windows.Forms.CheckBox licenseBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxWood;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox firNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
    }
}