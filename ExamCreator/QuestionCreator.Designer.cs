﻿namespace ExamCreator
{
    partial class QuestionCreator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Public = new System.Windows.Forms.RadioButton();
            this.rb_Private = new System.Windows.Forms.RadioButton();
            this.btn_SubmitQuestion = new System.Windows.Forms.Button();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.pb_QuestionImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.txt_QuestionTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_Mark = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tbar_Difficulty = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_Topics = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuestionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Difficulty)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Public);
            this.groupBox1.Controls.Add(this.rb_Private);
            this.groupBox1.Location = new System.Drawing.Point(288, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 58);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Privacy";
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
            // 
            // rb_Private
            // 
            this.rb_Private.AutoSize = true;
            this.rb_Private.Location = new System.Drawing.Point(67, 30);
            this.rb_Private.Name = "rb_Private";
            this.rb_Private.Size = new System.Drawing.Size(58, 17);
            this.rb_Private.TabIndex = 21;
            this.rb_Private.Text = "Private";
            this.rb_Private.UseVisualStyleBackColor = true;
            // 
            // btn_SubmitQuestion
            // 
            this.btn_SubmitQuestion.Location = new System.Drawing.Point(339, 260);
            this.btn_SubmitQuestion.Name = "btn_SubmitQuestion";
            this.btn_SubmitQuestion.Size = new System.Drawing.Size(99, 23);
            this.btn_SubmitQuestion.TabIndex = 35;
            this.btn_SubmitQuestion.Text = "Submit question";
            this.btn_SubmitQuestion.UseVisualStyleBackColor = true;
            this.btn_SubmitQuestion.Click += new System.EventHandler(this.btn_SubmitQuestion_Click);
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(357, 9);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(81, 23);
            this.btn_UploadImage.TabIndex = 32;
            this.btn_UploadImage.Text = "Upload image";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // pb_QuestionImage
            // 
            this.pb_QuestionImage.Location = new System.Drawing.Point(288, 38);
            this.pb_QuestionImage.Name = "pb_QuestionImage";
            this.pb_QuestionImage.Size = new System.Drawing.Size(150, 150);
            this.pb_QuestionImage.TabIndex = 31;
            this.pb_QuestionImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Image";
            // 
            // txt_Question
            // 
            this.txt_Question.Location = new System.Drawing.Point(113, 37);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(166, 20);
            this.txt_Question.TabIndex = 29;
            // 
            // txt_QuestionTitle
            // 
            this.txt_QuestionTitle.Location = new System.Drawing.Point(113, 9);
            this.txt_QuestionTitle.Name = "txt_QuestionTitle";
            this.txt_QuestionTitle.Size = new System.Drawing.Size(166, 20);
            this.txt_QuestionTitle.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Question title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Raw mark";
            // 
            // num_Mark
            // 
            this.num_Mark.Location = new System.Drawing.Point(113, 64);
            this.num_Mark.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Mark.Name = "num_Mark";
            this.num_Mark.Size = new System.Drawing.Size(166, 20);
            this.num_Mark.TabIndex = 38;
            this.num_Mark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Difficulty";
            // 
            // tbar_Difficulty
            // 
            this.tbar_Difficulty.Location = new System.Drawing.Point(113, 93);
            this.tbar_Difficulty.Maximum = 5;
            this.tbar_Difficulty.Minimum = 1;
            this.tbar_Difficulty.Name = "tbar_Difficulty";
            this.tbar_Difficulty.Size = new System.Drawing.Size(166, 45);
            this.tbar_Difficulty.TabIndex = 40;
            this.tbar_Difficulty.Value = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_Topics);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 139);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Topic";
            // 
            // lb_Topics
            // 
            this.lb_Topics.FormattingEnabled = true;
            this.lb_Topics.Items.AddRange(new object[] {
            "Databases",
            "Algorithims",
            "etc",
            "more"});
            this.lb_Topics.Location = new System.Drawing.Point(7, 20);
            this.lb_Topics.Name = "lb_Topics";
            this.lb_Topics.Size = new System.Drawing.Size(254, 108);
            this.lb_Topics.TabIndex = 0;
            // 
            // QuestionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 291);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tbar_Difficulty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Mark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SubmitQuestion);
            this.Controls.Add(this.btn_UploadImage);
            this.Controls.Add(this.pb_QuestionImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.txt_QuestionTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuestionCreator";
            this.Text = "Question Creator";
            this.Load += new System.EventHandler(this.QuestionCreator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuestionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Difficulty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Public;
        private System.Windows.Forms.RadioButton rb_Private;
        private System.Windows.Forms.Button btn_SubmitQuestion;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.PictureBox pb_QuestionImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Question;
        private System.Windows.Forms.TextBox txt_QuestionTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_Mark;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbar_Difficulty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lb_Topics;
    }
}