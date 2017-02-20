namespace ExamCreator
{
    partial class MarkingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkingForm));
            this.lb_QuestionNum = new System.Windows.Forms.Label();
            this.lb_Answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Mark = new System.Windows.Forms.NumericUpDown();
            this.lb_HighMark = new System.Windows.Forms.Label();
            this.txt_StudentAnswer = new System.Windows.Forms.TextBox();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_RightArrow = new System.Windows.Forms.Button();
            this.btn_LeftArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_Mark)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_QuestionNum
            // 
            this.lb_QuestionNum.AutoSize = true;
            this.lb_QuestionNum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionNum.Location = new System.Drawing.Point(12, 9);
            this.lb_QuestionNum.Name = "lb_QuestionNum";
            this.lb_QuestionNum.Size = new System.Drawing.Size(115, 17);
            this.lb_QuestionNum.TabIndex = 0;
            this.lb_QuestionNum.Text = "Question 1 of n: ";
            // 
            // lb_Answer
            // 
            this.lb_Answer.AutoSize = true;
            this.lb_Answer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Answer.Location = new System.Drawing.Point(9, 107);
            this.lb_Answer.Name = "lb_Answer";
            this.lb_Answer.Size = new System.Drawing.Size(129, 17);
            this.lb_Answer.TabIndex = 1;
            this.lb_Answer.Text = "Student\'s answer: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marks:";
            // 
            // num_Mark
            // 
            this.num_Mark.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Mark.Location = new System.Drawing.Point(107, 232);
            this.num_Mark.Name = "num_Mark";
            this.num_Mark.Size = new System.Drawing.Size(162, 25);
            this.num_Mark.TabIndex = 3;
            // 
            // lb_HighMark
            // 
            this.lb_HighMark.AutoSize = true;
            this.lb_HighMark.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lb_HighMark.Location = new System.Drawing.Point(104, 260);
            this.lb_HighMark.Name = "lb_HighMark";
            this.lb_HighMark.Size = new System.Drawing.Size(156, 14);
            this.lb_HighMark.TabIndex = 4;
            this.lb_HighMark.Text = "Highest mark for this question: ";
            // 
            // txt_StudentAnswer
            // 
            this.txt_StudentAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_StudentAnswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentAnswer.Location = new System.Drawing.Point(12, 127);
            this.txt_StudentAnswer.Multiline = true;
            this.txt_StudentAnswer.Name = "txt_StudentAnswer";
            this.txt_StudentAnswer.ReadOnly = true;
            this.txt_StudentAnswer.Size = new System.Drawing.Size(259, 99);
            this.txt_StudentAnswer.TabIndex = 5;
            // 
            // txt_Question
            // 
            this.txt_Question.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Question.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Question.Location = new System.Drawing.Point(15, 30);
            this.txt_Question.Multiline = true;
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.ReadOnly = true;
            this.txt_Question.Size = new System.Drawing.Size(254, 52);
            this.txt_Question.TabIndex = 6;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.White;
            this.btn_Submit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Submit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(56, 317);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(172, 24);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit test";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_RightArrow
            // 
            this.btn_RightArrow.BackColor = System.Drawing.Color.White;
            this.btn_RightArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RightArrow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RightArrow.Location = new System.Drawing.Point(234, 311);
            this.btn_RightArrow.Name = "btn_RightArrow";
            this.btn_RightArrow.Size = new System.Drawing.Size(38, 34);
            this.btn_RightArrow.TabIndex = 8;
            this.btn_RightArrow.Text = "→";
            this.btn_RightArrow.UseVisualStyleBackColor = false;
            this.btn_RightArrow.Click += new System.EventHandler(this.btn_RightArrow_Click);
            // 
            // btn_LeftArrow
            // 
            this.btn_LeftArrow.BackColor = System.Drawing.Color.White;
            this.btn_LeftArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LeftArrow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeftArrow.Location = new System.Drawing.Point(12, 311);
            this.btn_LeftArrow.Name = "btn_LeftArrow";
            this.btn_LeftArrow.Size = new System.Drawing.Size(38, 34);
            this.btn_LeftArrow.TabIndex = 7;
            this.btn_LeftArrow.Text = "←";
            this.btn_LeftArrow.UseVisualStyleBackColor = false;
            this.btn_LeftArrow.Click += new System.EventHandler(this.btn_LeftArrow_Click);
            // 
            // MarkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 357);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_RightArrow);
            this.Controls.Add(this.btn_LeftArrow);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.txt_StudentAnswer);
            this.Controls.Add(this.lb_HighMark);
            this.Controls.Add(this.num_Mark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Answer);
            this.Controls.Add(this.lb_QuestionNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarkingForm";
            this.Text = "MarkingForm";
            ((System.ComponentModel.ISupportInitialize)(this.num_Mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_QuestionNum;
        private System.Windows.Forms.Label lb_Answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Mark;
        private System.Windows.Forms.Label lb_HighMark;
        private System.Windows.Forms.TextBox txt_StudentAnswer;
        private System.Windows.Forms.TextBox txt_Question;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_RightArrow;
        private System.Windows.Forms.Button btn_LeftArrow;
    }
}