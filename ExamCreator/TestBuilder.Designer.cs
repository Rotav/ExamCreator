﻿namespace ExamCreator
{
    partial class TestBuilder
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
            this.lb_QuestionList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_QuestionContent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Public = new System.Windows.Forms.TabPage();
            this.dg_Public = new System.Windows.Forms.DataGridView();
            this.tp_Private = new System.Windows.Forms.TabPage();
            this.btn_DeleteQuestionTest = new System.Windows.Forms.Button();
            this.btn_AddQuestion = new System.Windows.Forms.Button();
            this.btn_CreateQuestion = new System.Windows.Forms.Button();
            this.btn_DeleteQuestion = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_Public.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Public)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_QuestionList
            // 
            this.lb_QuestionList.FormattingEnabled = true;
            this.lb_QuestionList.Location = new System.Drawing.Point(447, 12);
            this.lb_QuestionList.Name = "lb_QuestionList";
            this.lb_QuestionList.Size = new System.Drawing.Size(198, 342);
            this.lb_QuestionList.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_QuestionContent);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 342);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marks: ";
            // 
            // lb_QuestionContent
            // 
            this.lb_QuestionContent.AutoSize = true;
            this.lb_QuestionContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionContent.Location = new System.Drawing.Point(62, 27);
            this.lb_QuestionContent.Name = "lb_QuestionContent";
            this.lb_QuestionContent.Size = new System.Drawing.Size(304, 20);
            this.lb_QuestionContent.TabIndex = 1;
            this.lb_QuestionContent.Text = "How can mirrors be real if our eyes aren\'t?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 156);
            this.textBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Public);
            this.tabControl1.Controls.Add(this.tp_Private);
            this.tabControl1.Location = new System.Drawing.Point(13, 360);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 150);
            this.tabControl1.TabIndex = 12;
            // 
            // tp_Public
            // 
            this.tp_Public.Controls.Add(this.dg_Public);
            this.tp_Public.Location = new System.Drawing.Point(4, 22);
            this.tp_Public.Name = "tp_Public";
            this.tp_Public.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Public.Size = new System.Drawing.Size(420, 124);
            this.tp_Public.TabIndex = 0;
            this.tp_Public.Text = "Public";
            this.tp_Public.UseVisualStyleBackColor = true;
            // 
            // dg_Public
            // 
            this.dg_Public.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Public.Location = new System.Drawing.Point(6, 6);
            this.dg_Public.Name = "dg_Public";
            this.dg_Public.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Public.Size = new System.Drawing.Size(408, 112);
            this.dg_Public.TabIndex = 0;
            // 
            // tp_Private
            // 
            this.tp_Private.Location = new System.Drawing.Point(4, 22);
            this.tp_Private.Name = "tp_Private";
            this.tp_Private.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Private.Size = new System.Drawing.Size(420, 124);
            this.tp_Private.TabIndex = 1;
            this.tp_Private.Text = "Private";
            this.tp_Private.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteQuestionTest
            // 
            this.btn_DeleteQuestionTest.Location = new System.Drawing.Point(447, 360);
            this.btn_DeleteQuestionTest.Name = "btn_DeleteQuestionTest";
            this.btn_DeleteQuestionTest.Size = new System.Drawing.Size(198, 23);
            this.btn_DeleteQuestionTest.TabIndex = 13;
            this.btn_DeleteQuestionTest.Text = "Delete Question from test";
            this.btn_DeleteQuestionTest.UseVisualStyleBackColor = true;
            this.btn_DeleteQuestionTest.Click += new System.EventHandler(this.btn_DeleteQuestion_Click);
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.Location = new System.Drawing.Point(12, 512);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(111, 23);
            this.btn_AddQuestion.TabIndex = 14;
            this.btn_AddQuestion.Text = "Add Question to test";
            this.btn_AddQuestion.UseVisualStyleBackColor = true;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // btn_CreateQuestion
            // 
            this.btn_CreateQuestion.Location = new System.Drawing.Point(329, 512);
            this.btn_CreateQuestion.Name = "btn_CreateQuestion";
            this.btn_CreateQuestion.Size = new System.Drawing.Size(113, 23);
            this.btn_CreateQuestion.TabIndex = 15;
            this.btn_CreateQuestion.Text = "Create new question";
            this.btn_CreateQuestion.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteQuestion
            // 
            this.btn_DeleteQuestion.Location = new System.Drawing.Point(229, 512);
            this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            this.btn_DeleteQuestion.Size = new System.Drawing.Size(94, 23);
            this.btn_DeleteQuestion.TabIndex = 16;
            this.btn_DeleteQuestion.Text = "Delete question";
            this.btn_DeleteQuestion.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(129, 512);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(94, 23);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "Edit question";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // TestBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 540);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_DeleteQuestion);
            this.Controls.Add(this.btn_CreateQuestion);
            this.Controls.Add(this.btn_AddQuestion);
            this.Controls.Add(this.btn_DeleteQuestionTest);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_QuestionList);
            this.Name = "TestBuilder";
            this.Text = "Test Builder";
            this.Load += new System.EventHandler(this.TestBuilder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_Public.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Public)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_QuestionList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Public;
        private System.Windows.Forms.TabPage tp_Private;
        private System.Windows.Forms.Button btn_DeleteQuestionTest;
        private System.Windows.Forms.Button btn_AddQuestion;
        private System.Windows.Forms.Button btn_CreateQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_QuestionContent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dg_Public;
        private System.Windows.Forms.Button btn_DeleteQuestion;
        private System.Windows.Forms.Button btn_Edit;

    }
}