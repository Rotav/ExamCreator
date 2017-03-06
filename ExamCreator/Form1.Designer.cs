namespace ExamCreator
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_StudentLogin = new System.Windows.Forms.Button();
            this.btn_LoginTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Username.Location = new System.Drawing.Point(8, 13);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(80, 18);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.Click += new System.EventHandler(this.lbl_Username_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Password.Location = new System.Drawing.Point(8, 39);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 18);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(101, 12);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(108, 20);
            this.txt_Username.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(101, 38);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(108, 20);
            this.txt_Password.TabIndex = 3;
            // 
            // btn_StudentLogin
            // 
            this.btn_StudentLogin.BackColor = System.Drawing.Color.White;
            this.btn_StudentLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_StudentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StudentLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentLogin.Location = new System.Drawing.Point(15, 71);
            this.btn_StudentLogin.Name = "btn_StudentLogin";
            this.btn_StudentLogin.Size = new System.Drawing.Size(80, 38);
            this.btn_StudentLogin.TabIndex = 4;
            this.btn_StudentLogin.Text = "Login as student";
            this.btn_StudentLogin.UseVisualStyleBackColor = false;
            this.btn_StudentLogin.Click += new System.EventHandler(this.btn_Lbtn_Loginogin_Click);
            // 
            // btn_LoginTeacher
            // 
            this.btn_LoginTeacher.BackColor = System.Drawing.Color.White;
            this.btn_LoginTeacher.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoginTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LoginTeacher.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginTeacher.Location = new System.Drawing.Point(129, 71);
            this.btn_LoginTeacher.Name = "btn_LoginTeacher";
            this.btn_LoginTeacher.Size = new System.Drawing.Size(80, 38);
            this.btn_LoginTeacher.TabIndex = 6;
            this.btn_LoginTeacher.Text = "Login as teacher";
            this.btn_LoginTeacher.UseVisualStyleBackColor = false;
            this.btn_LoginTeacher.Click += new System.EventHandler(this.btn_LoginTeacher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(221, 121);
            this.Controls.Add(this.btn_LoginTeacher);
            this.Controls.Add(this.btn_StudentLogin);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_StudentLogin;
        private System.Windows.Forms.Button btn_LoginTeacher;
    }
}

