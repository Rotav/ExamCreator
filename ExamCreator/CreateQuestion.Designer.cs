namespace ExamCreator
{
    partial class CreateQuestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_QuestionTitle = new System.Windows.Forms.TextBox();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_QuestionImage = new System.Windows.Forms.PictureBox();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.txt_OptionText = new System.Windows.Forms.TextBox();
            this.lb_Options = new System.Windows.Forms.ListBox();
            this.btn_DeleteOption = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Correct = new System.Windows.Forms.CheckBox();
            this.btn_AddOption = new System.Windows.Forms.Button();
            this.rb_Multiple = new System.Windows.Forms.RadioButton();
            this.rb_Single = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rb_Public = new System.Windows.Forms.RadioButton();
            this.rb_SameSchool = new System.Windows.Forms.RadioButton();
            this.rb_Private = new System.Windows.Forms.RadioButton();
            this.btn_SubmitQuestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuestionImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question";
            // 
            // txt_QuestionTitle
            // 
            this.txt_QuestionTitle.Location = new System.Drawing.Point(113, 9);
            this.txt_QuestionTitle.Name = "txt_QuestionTitle";
            this.txt_QuestionTitle.Size = new System.Drawing.Size(166, 20);
            this.txt_QuestionTitle.TabIndex = 2;
            // 
            // txt_Question
            // 
            this.txt_Question.Location = new System.Drawing.Point(113, 37);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(166, 20);
            this.txt_Question.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Image";
            // 
            // pb_QuestionImage
            // 
            this.pb_QuestionImage.Location = new System.Drawing.Point(15, 97);
            this.pb_QuestionImage.Name = "pb_QuestionImage";
            this.pb_QuestionImage.Size = new System.Drawing.Size(150, 150);
            this.pb_QuestionImage.TabIndex = 6;
            this.pb_QuestionImage.TabStop = false;
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(84, 68);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(81, 23);
            this.btn_UploadImage.TabIndex = 7;
            this.btn_UploadImage.Text = "Upload image";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // txt_OptionText
            // 
            this.txt_OptionText.Location = new System.Drawing.Point(91, 14);
            this.txt_OptionText.Name = "txt_OptionText";
            this.txt_OptionText.Size = new System.Drawing.Size(119, 20);
            this.txt_OptionText.TabIndex = 8;
            // 
            // lb_Options
            // 
            this.lb_Options.FormattingEnabled = true;
            this.lb_Options.Location = new System.Drawing.Point(430, 90);
            this.lb_Options.Name = "lb_Options";
            this.lb_Options.Size = new System.Drawing.Size(198, 173);
            this.lb_Options.TabIndex = 9;
            // 
            // btn_DeleteOption
            // 
            this.btn_DeleteOption.Location = new System.Drawing.Point(536, 270);
            this.btn_DeleteOption.Name = "btn_DeleteOption";
            this.btn_DeleteOption.Size = new System.Drawing.Size(92, 23);
            this.btn_DeleteOption.TabIndex = 10;
            this.btn_DeleteOption.Text = "Delete option";
            this.btn_DeleteOption.UseVisualStyleBackColor = true;
            this.btn_DeleteOption.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Option text";
            // 
            // cb_Correct
            // 
            this.cb_Correct.AutoSize = true;
            this.cb_Correct.Location = new System.Drawing.Point(117, 49);
            this.cb_Correct.Name = "cb_Correct";
            this.cb_Correct.Size = new System.Drawing.Size(93, 17);
            this.cb_Correct.TabIndex = 13;
            this.cb_Correct.Text = "Option correct";
            this.cb_Correct.UseVisualStyleBackColor = true;
            // 
            // btn_AddOption
            // 
            this.btn_AddOption.Location = new System.Drawing.Point(135, 73);
            this.btn_AddOption.Name = "btn_AddOption";
            this.btn_AddOption.Size = new System.Drawing.Size(75, 23);
            this.btn_AddOption.TabIndex = 14;
            this.btn_AddOption.Text = "Add option";
            this.btn_AddOption.UseVisualStyleBackColor = true;
            this.btn_AddOption.Click += new System.EventHandler(this.btn_AddOption_Click);
            // 
            // rb_Multiple
            // 
            this.rb_Multiple.AutoSize = true;
            this.rb_Multiple.Location = new System.Drawing.Point(104, 39);
            this.rb_Multiple.Name = "rb_Multiple";
            this.rb_Multiple.Size = new System.Drawing.Size(96, 17);
            this.rb_Multiple.TabIndex = 16;
            this.rb_Multiple.Text = "Multiple choice";
            this.rb_Multiple.UseVisualStyleBackColor = true;
            // 
            // rb_Single
            // 
            this.rb_Single.AutoSize = true;
            this.rb_Single.Checked = true;
            this.rb_Single.Location = new System.Drawing.Point(9, 38);
            this.rb_Single.Name = "rb_Single";
            this.rb_Single.Size = new System.Drawing.Size(89, 17);
            this.rb_Single.TabIndex = 17;
            this.rb_Single.TabStop = true;
            this.rb_Single.Text = "Single choice";
            this.rb_Single.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rb_Public
            // 
            this.rb_Public.AutoSize = true;
            this.rb_Public.Checked = true;
            this.rb_Public.Location = new System.Drawing.Point(7, 30);
            this.rb_Public.Name = "rb_Public";
            this.rb_Public.Size = new System.Drawing.Size(54, 17);
            this.rb_Public.TabIndex = 19;
            this.rb_Public.TabStop = true;
            this.rb_Public.Text = "Public";
            this.rb_Public.UseVisualStyleBackColor = true;
            this.rb_Public.CheckedChanged += new System.EventHandler(this.rb_Public_CheckedChanged);
            // 
            // rb_SameSchool
            // 
            this.rb_SameSchool.AutoSize = true;
            this.rb_SameSchool.Location = new System.Drawing.Point(67, 30);
            this.rb_SameSchool.Name = "rb_SameSchool";
            this.rb_SameSchool.Size = new System.Drawing.Size(100, 17);
            this.rb_SameSchool.TabIndex = 20;
            this.rb_SameSchool.Text = "Same school ID";
            this.rb_SameSchool.UseVisualStyleBackColor = true;
            this.rb_SameSchool.CheckedChanged += new System.EventHandler(this.rb_SameSchool_CheckedChanged);
            // 
            // rb_Private
            // 
            this.rb_Private.AutoSize = true;
            this.rb_Private.Location = new System.Drawing.Point(173, 30);
            this.rb_Private.Name = "rb_Private";
            this.rb_Private.Size = new System.Drawing.Size(58, 17);
            this.rb_Private.TabIndex = 21;
            this.rb_Private.Text = "Private";
            this.rb_Private.UseVisualStyleBackColor = true;
            this.rb_Private.CheckedChanged += new System.EventHandler(this.rb_Private_CheckedChanged);
            // 
            // btn_SubmitQuestion
            // 
            this.btn_SubmitQuestion.Location = new System.Drawing.Point(151, 332);
            this.btn_SubmitQuestion.Name = "btn_SubmitQuestion";
            this.btn_SubmitQuestion.Size = new System.Drawing.Size(99, 23);
            this.btn_SubmitQuestion.TabIndex = 22;
            this.btn_SubmitQuestion.Text = "Submit question";
            this.btn_SubmitQuestion.UseVisualStyleBackColor = true;
            this.btn_SubmitQuestion.Click += new System.EventHandler(this.btn_SubmitQuestion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Public);
            this.groupBox1.Controls.Add(this.rb_Private);
            this.groupBox1.Controls.Add(this.rb_SameSchool);
            this.groupBox1.Location = new System.Drawing.Point(15, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 58);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Privacy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Multiple);
            this.groupBox2.Controls.Add(this.rb_Single);
            this.groupBox2.Location = new System.Drawing.Point(429, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 72);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_OptionText);
            this.groupBox3.Controls.Add(this.cb_Correct);
            this.groupBox3.Controls.Add(this.btn_AddOption);
            this.groupBox3.Location = new System.Drawing.Point(206, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 367);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SubmitQuestion);
            this.Controls.Add(this.btn_DeleteOption);
            this.Controls.Add(this.lb_Options);
            this.Controls.Add(this.btn_UploadImage);
            this.Controls.Add(this.pb_QuestionImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.txt_QuestionTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateQuestion";
            this.Text = "Create Question";
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuestionImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_SubmitQuestion_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_QuestionTitle;
        private System.Windows.Forms.TextBox txt_Question;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_QuestionImage;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.TextBox txt_OptionText;
        private System.Windows.Forms.ListBox lb_Options;
        private System.Windows.Forms.Button btn_DeleteOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_Correct;
        private System.Windows.Forms.Button btn_AddOption;
        private System.Windows.Forms.RadioButton rb_Multiple;
        private System.Windows.Forms.RadioButton rb_Single;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rb_Public;
        private System.Windows.Forms.RadioButton rb_SameSchool;
        private System.Windows.Forms.RadioButton rb_Private;
        private System.Windows.Forms.Button btn_SubmitQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}