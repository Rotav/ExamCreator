namespace ExamCreator
{
    partial class CreateAccount
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
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Confirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_createacc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rad_Student = new System.Windows.Forms.RadioButton();
            this.rad_Teacher = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_forename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_schoolID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(157, 111);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(136, 20);
            this.txt_Username.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(157, 137);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(136, 20);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.Location = new System.Drawing.Point(157, 163);
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.PasswordChar = '*';
            this.txt_Confirm.Size = new System.Drawing.Size(136, 20);
            this.txt_Confirm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm password";
            // 
            // btn_createacc
            // 
            this.btn_createacc.Location = new System.Drawing.Point(204, 189);
            this.btn_createacc.Name = "btn_createacc";
            this.btn_createacc.Size = new System.Drawing.Size(89, 23);
            this.btn_createacc.TabIndex = 7;
            this.btn_createacc.Text = "Create account";
            this.btn_createacc.UseVisualStyleBackColor = true;
            this.btn_createacc.Click += new System.EventHandler(this.btn_createacc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Account type";
            // 
            // rad_Student
            // 
            this.rad_Student.AutoSize = true;
            this.rad_Student.Location = new System.Drawing.Point(157, 9);
            this.rad_Student.Name = "rad_Student";
            this.rad_Student.Size = new System.Drawing.Size(62, 17);
            this.rad_Student.TabIndex = 9;
            this.rad_Student.TabStop = true;
            this.rad_Student.Text = "Student";
            this.rad_Student.UseVisualStyleBackColor = true;
            // 
            // rad_Teacher
            // 
            this.rad_Teacher.AutoSize = true;
            this.rad_Teacher.Location = new System.Drawing.Point(225, 9);
            this.rad_Teacher.Name = "rad_Teacher";
            this.rad_Teacher.Size = new System.Drawing.Size(65, 17);
            this.rad_Teacher.TabIndex = 10;
            this.rad_Teacher.TabStop = true;
            this.rad_Teacher.Text = "Teacher";
            this.rad_Teacher.UseVisualStyleBackColor = true;
            this.rad_Teacher.CheckedChanged += new System.EventHandler(this.rad_Teacher_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Forename";
            // 
            // txt_forename
            // 
            this.txt_forename.Location = new System.Drawing.Point(157, 58);
            this.txt_forename.Name = "txt_forename";
            this.txt_forename.Size = new System.Drawing.Size(136, 20);
            this.txt_forename.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Surname";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(157, 85);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(136, 20);
            this.txt_surname.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "School ID";
            // 
            // txt_schoolID
            // 
            this.txt_schoolID.Location = new System.Drawing.Point(157, 32);
            this.txt_schoolID.Name = "txt_schoolID";
            this.txt_schoolID.Size = new System.Drawing.Size(136, 20);
            this.txt_schoolID.TabIndex = 15;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 222);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_schoolID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_forename);
            this.Controls.Add(this.rad_Teacher);
            this.Controls.Add(this.rad_Student);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_createacc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Confirm);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Name = "CreateAccount";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_createacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rad_Student;
        private System.Windows.Forms.RadioButton rad_Teacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_forename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_schoolID;
    }
}