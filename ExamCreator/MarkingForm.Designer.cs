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
            this.lb_Question = new System.Windows.Forms.Label();
            this.lb_Answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_StudentAnswer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_RightArrow = new System.Windows.Forms.Button();
            this.btn_LeftArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Question
            // 
            this.lb_Question.AutoSize = true;
            this.lb_Question.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Question.Location = new System.Drawing.Point(12, 9);
            this.lb_Question.Name = "lb_Question";
            this.lb_Question.Size = new System.Drawing.Size(115, 17);
            this.lb_Question.TabIndex = 0;
            this.lb_Question.Text = "Question 1 of n: ";
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(107, 232);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Highest mark for this question: ";
            // 
            // tb_StudentAnswer
            // 
            this.tb_StudentAnswer.Location = new System.Drawing.Point(12, 127);
            this.tb_StudentAnswer.Multiline = true;
            this.tb_StudentAnswer.Name = "tb_StudentAnswer";
            this.tb_StudentAnswer.Size = new System.Drawing.Size(259, 99);
            this.tb_StudentAnswer.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 52);
            this.textBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(56, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Submit test";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_RightArrow
            // 
            this.btn_RightArrow.BackColor = System.Drawing.Color.White;
            this.btn_RightArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RightArrow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RightArrow.Location = new System.Drawing.Point(234, 311);
            this.btn_RightArrow.Name = "btn_RightArrow";
            this.btn_RightArrow.Size = new System.Drawing.Size(38, 34);
            this.btn_RightArrow.TabIndex = 8;
            this.btn_RightArrow.Text = "→";
            this.btn_RightArrow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_RightArrow.UseVisualStyleBackColor = false;
            // 
            // btn_LeftArrow
            // 
            this.btn_LeftArrow.BackColor = System.Drawing.Color.White;
            this.btn_LeftArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LeftArrow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeftArrow.Location = new System.Drawing.Point(12, 311);
            this.btn_LeftArrow.Name = "btn_LeftArrow";
            this.btn_LeftArrow.Size = new System.Drawing.Size(38, 34);
            this.btn_LeftArrow.TabIndex = 7;
            this.btn_LeftArrow.Text = "←";
            this.btn_LeftArrow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_LeftArrow.UseVisualStyleBackColor = false;
            // 
            // MarkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 357);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_RightArrow);
            this.Controls.Add(this.btn_LeftArrow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_StudentAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Answer);
            this.Controls.Add(this.lb_Question);
            this.Name = "MarkingForm";
            this.Text = "MarkingForm";
            this.Load += new System.EventHandler(this.MarkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Question;
        private System.Windows.Forms.Label lb_Answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_StudentAnswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_RightArrow;
        private System.Windows.Forms.Button btn_LeftArrow;
    }
}