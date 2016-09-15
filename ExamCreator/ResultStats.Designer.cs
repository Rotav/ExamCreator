namespace ExamCreator
{
    partial class ResultStats
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
            this.btn_RightArrow = new System.Windows.Forms.Button();
            this.btn_LeftArrow = new System.Windows.Forms.Button();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.txt_StudentAnswer = new System.Windows.Forms.TextBox();
            this.lb_QuestionHigh = new System.Windows.Forms.Label();
            this.lb_QuestionMarks = new System.Windows.Forms.Label();
            this.lb_Answer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_QuestionNum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_QuestionPercent = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_TestPercent = new System.Windows.Forms.Label();
            this.lb_TestHigh = new System.Windows.Forms.Label();
            this.lb_TestMarks = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_RightArrow
            // 
            this.btn_RightArrow.BackColor = System.Drawing.Color.White;
            this.btn_RightArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RightArrow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RightArrow.Location = new System.Drawing.Point(230, 232);
            this.btn_RightArrow.Name = "btn_RightArrow";
            this.btn_RightArrow.Size = new System.Drawing.Size(38, 34);
            this.btn_RightArrow.TabIndex = 18;
            this.btn_RightArrow.Text = "→";
            this.btn_RightArrow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_RightArrow.UseVisualStyleBackColor = false;
            this.btn_RightArrow.Click += new System.EventHandler(this.btn_RightArrow_Click);
            // 
            // btn_LeftArrow
            // 
            this.btn_LeftArrow.BackColor = System.Drawing.Color.White;
            this.btn_LeftArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LeftArrow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeftArrow.Location = new System.Drawing.Point(9, 232);
            this.btn_LeftArrow.Name = "btn_LeftArrow";
            this.btn_LeftArrow.Size = new System.Drawing.Size(38, 34);
            this.btn_LeftArrow.TabIndex = 17;
            this.btn_LeftArrow.Text = "←";
            this.btn_LeftArrow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_LeftArrow.UseVisualStyleBackColor = false;
            this.btn_LeftArrow.Click += new System.EventHandler(this.btn_LeftArrow_Click);
            // 
            // txt_Question
            // 
            this.txt_Question.Location = new System.Drawing.Point(9, 43);
            this.txt_Question.Multiline = true;
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.ReadOnly = true;
            this.txt_Question.Size = new System.Drawing.Size(254, 52);
            this.txt_Question.TabIndex = 16;
            // 
            // txt_StudentAnswer
            // 
            this.txt_StudentAnswer.Location = new System.Drawing.Point(9, 127);
            this.txt_StudentAnswer.Multiline = true;
            this.txt_StudentAnswer.Name = "txt_StudentAnswer";
            this.txt_StudentAnswer.ReadOnly = true;
            this.txt_StudentAnswer.Size = new System.Drawing.Size(259, 99);
            this.txt_StudentAnswer.TabIndex = 15;
            // 
            // lb_QuestionHigh
            // 
            this.lb_QuestionHigh.AutoSize = true;
            this.lb_QuestionHigh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionHigh.Location = new System.Drawing.Point(6, 55);
            this.lb_QuestionHigh.Name = "lb_QuestionHigh";
            this.lb_QuestionHigh.Size = new System.Drawing.Size(175, 17);
            this.lb_QuestionHigh.TabIndex = 14;
            this.lb_QuestionHigh.Text = "Highest mark achievable: ";
            // 
            // lb_QuestionMarks
            // 
            this.lb_QuestionMarks.AutoSize = true;
            this.lb_QuestionMarks.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionMarks.Location = new System.Drawing.Point(6, 23);
            this.lb_QuestionMarks.Name = "lb_QuestionMarks";
            this.lb_QuestionMarks.Size = new System.Drawing.Size(114, 17);
            this.lb_QuestionMarks.TabIndex = 12;
            this.lb_QuestionMarks.Text = "Marks recieved: ";
            // 
            // lb_Answer
            // 
            this.lb_Answer.AutoSize = true;
            this.lb_Answer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Answer.Location = new System.Drawing.Point(6, 107);
            this.lb_Answer.Name = "lb_Answer";
            this.lb_Answer.Size = new System.Drawing.Size(129, 17);
            this.lb_Answer.TabIndex = 11;
            this.lb_Answer.Text = "Student\'s answer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Question asked: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_QuestionNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_Answer);
            this.groupBox1.Controls.Add(this.txt_StudentAnswer);
            this.groupBox1.Controls.Add(this.btn_RightArrow);
            this.groupBox1.Controls.Add(this.txt_Question);
            this.groupBox1.Controls.Add(this.btn_LeftArrow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 278);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question data";
            // 
            // lb_QuestionNum
            // 
            this.lb_QuestionNum.AutoSize = true;
            this.lb_QuestionNum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionNum.Location = new System.Drawing.Point(80, 241);
            this.lb_QuestionNum.Name = "lb_QuestionNum";
            this.lb_QuestionNum.Size = new System.Drawing.Size(107, 17);
            this.lb_QuestionNum.TabIndex = 21;
            this.lb_QuestionNum.Text = "Question 1 of n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_QuestionPercent);
            this.groupBox2.Controls.Add(this.lb_QuestionHigh);
            this.groupBox2.Controls.Add(this.lb_QuestionMarks);
            this.groupBox2.Location = new System.Drawing.Point(320, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 111);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question statistics";
            // 
            // lb_QuestionPercent
            // 
            this.lb_QuestionPercent.AutoSize = true;
            this.lb_QuestionPercent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionPercent.Location = new System.Drawing.Point(6, 87);
            this.lb_QuestionPercent.Name = "lb_QuestionPercent";
            this.lb_QuestionPercent.Size = new System.Drawing.Size(140, 17);
            this.lb_QuestionPercent.TabIndex = 15;
            this.lb_QuestionPercent.Text = "Percentage scored: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_TestPercent);
            this.groupBox3.Controls.Add(this.lb_TestHigh);
            this.groupBox3.Controls.Add(this.lb_TestMarks);
            this.groupBox3.Location = new System.Drawing.Point(316, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 121);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test statistics";
            // 
            // lb_TestPercent
            // 
            this.lb_TestPercent.AutoSize = true;
            this.lb_TestPercent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TestPercent.Location = new System.Drawing.Point(6, 87);
            this.lb_TestPercent.Name = "lb_TestPercent";
            this.lb_TestPercent.Size = new System.Drawing.Size(172, 17);
            this.lb_TestPercent.TabIndex = 15;
            this.lb_TestPercent.Text = "Total percentage scored: ";
            // 
            // lb_TestHigh
            // 
            this.lb_TestHigh.AutoSize = true;
            this.lb_TestHigh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TestHigh.Location = new System.Drawing.Point(6, 55);
            this.lb_TestHigh.Name = "lb_TestHigh";
            this.lb_TestHigh.Size = new System.Drawing.Size(206, 17);
            this.lb_TestHigh.TabIndex = 14;
            this.lb_TestHigh.Text = "Highest total mark achievable: ";
            // 
            // lb_TestMarks
            // 
            this.lb_TestMarks.AutoSize = true;
            this.lb_TestMarks.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TestMarks.Location = new System.Drawing.Point(6, 23);
            this.lb_TestMarks.Name = "lb_TestMarks";
            this.lb_TestMarks.Size = new System.Drawing.Size(150, 17);
            this.lb_TestMarks.TabIndex = 12;
            this.lb_TestMarks.Text = "Total marks recieved: ";
            // 
            // ResultStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 301);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultStats";
            this.Text = "ResultStats";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RightArrow;
        private System.Windows.Forms.Button btn_LeftArrow;
        private System.Windows.Forms.TextBox txt_Question;
        private System.Windows.Forms.TextBox txt_StudentAnswer;
        private System.Windows.Forms.Label lb_QuestionHigh;
        private System.Windows.Forms.Label lb_QuestionMarks;
        private System.Windows.Forms.Label lb_Answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_QuestionNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_QuestionPercent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_TestPercent;
        private System.Windows.Forms.Label lb_TestHigh;
        private System.Windows.Forms.Label lb_TestMarks;

    }
}