namespace ITI_APP_TEST
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.labelForename = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.swpic = new System.Windows.Forms.PictureBox();
            this.eyepic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.LoginBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.swpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(337, 107);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(263, 23);
            this.txt_username.TabIndex = 115;
            // 
            // labelForename
            // 
            this.labelForename.AutoSize = true;
            this.labelForename.BackColor = System.Drawing.Color.Transparent;
            this.labelForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelForename.Location = new System.Drawing.Point(137, 98);
            this.labelForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForename.Name = "labelForename";
            this.labelForename.Size = new System.Drawing.Size(146, 29);
            this.labelForename.TabIndex = 116;
            this.labelForename.Text = "Username :";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.Transparent;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSurname.Location = new System.Drawing.Point(143, 153);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(142, 29);
            this.labelSurname.TabIndex = 117;
            this.labelSurname.Text = "Password :";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(337, 158);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = 'x';
            this.txt_password.Size = new System.Drawing.Size(263, 23);
            this.txt_password.TabIndex = 118;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // swpic
            // 
            this.swpic.BackColor = System.Drawing.Color.White;
            this.swpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swpic.Image = global::ITI_APP_TEST.Properties.Resources.hide;
            this.swpic.Location = new System.Drawing.Point(1072, 528);
            this.swpic.Name = "swpic";
            this.swpic.Size = new System.Drawing.Size(27, 36);
            this.swpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swpic.TabIndex = 137;
            this.swpic.TabStop = false;
            this.swpic.Visible = false;
            // 
            // eyepic
            // 
            this.eyepic.BackColor = System.Drawing.Color.White;
            this.eyepic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyepic.Image = global::ITI_APP_TEST.Properties.Resources.show;
            this.eyepic.Location = new System.Drawing.Point(1104, 528);
            this.eyepic.Name = "eyepic";
            this.eyepic.Size = new System.Drawing.Size(27, 36);
            this.eyepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyepic.TabIndex = 136;
            this.eyepic.TabStop = false;
            this.eyepic.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ITI_APP_TEST.Properties.Resources.hide;
            this.pictureBox2.Location = new System.Drawing.Point(606, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 135;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // roleBox
            // 
            this.roleBox.DisplayMember = "Manager";
            this.roleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Instructor",
            "Student"});
            this.roleBox.Location = new System.Drawing.Point(337, 211);
            this.roleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(263, 25);
            this.roleBox.TabIndex = 132;
            this.roleBox.Tag = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(143, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 29);
            this.label19.TabIndex = 131;
            this.label19.Text = "Role :";
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.LoginBTN.FlatAppearance.BorderSize = 0;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.Color.Black;
            this.LoginBTN.Location = new System.Drawing.Point(229, 291);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(284, 42);
            this.LoginBTN.TabIndex = 130;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITI_APP_TEST.Properties.Resources.Group_10__12_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 411);
            this.Controls.Add(this.swpic);
            this.Controls.Add(this.eyepic);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.labelForename);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.txt_password);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseHover += new System.EventHandler(this.LoginForm_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.swpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label labelForename;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox swpic;
        private System.Windows.Forms.PictureBox eyepic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button LoginBTN;
    }
}