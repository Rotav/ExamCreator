namespace ExamCreator
{
    partial class Test
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
            this.txt_AnswerBox = new System.Windows.Forms.TextBox();
            this.btn_LeftArrow = new System.Windows.Forms.Button();
            this.btn_RightArrow = new System.Windows.Forms.Button();
            this.lb_QuestionNum = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_QuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_AnswerBox
            // 
            this.txt_AnswerBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AnswerBox.Location = new System.Drawing.Point(12, 96);
            this.txt_AnswerBox.Multiline = true;
            this.txt_AnswerBox.Name = "txt_AnswerBox";
            this.txt_AnswerBox.Size = new System.Drawing.Size(444, 112);
            this.txt_AnswerBox.TabIndex = 1;
            // 
            // btn_LeftArrow
            // 
            this.btn_LeftArrow.BackColor = System.Drawing.Color.White;
            this.btn_LeftArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LeftArrow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeftArrow.Location = new System.Drawing.Point(12, 214);
            this.btn_LeftArrow.Name = "btn_LeftArrow";
            this.btn_LeftArrow.Size = new System.Drawing.Size(38, 34);
            this.btn_LeftArrow.TabIndex = 2;
            this.btn_LeftArrow.Text = "←";
            this.btn_LeftArrow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_LeftArrow.UseVisualStyleBackColor = false;
            this.btn_LeftArrow.Click += new System.EventHandler(this.btn_LeftArrow_Click);
            // 
            // btn_RightArrow
            // 
            this.btn_RightArrow.BackColor = System.Drawing.Color.White;
            this.btn_RightArrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RightArrow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RightArrow.Location = new System.Drawing.Point(418, 214);
            this.btn_RightArrow.Name = "btn_RightArrow";
            this.btn_RightArrow.Size = new System.Drawing.Size(38, 34);
            this.btn_RightArrow.TabIndex = 3;
            this.btn_RightArrow.Text = "→";
            this.btn_RightArrow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_RightArrow.UseVisualStyleBackColor = false;
            this.btn_RightArrow.Click += new System.EventHandler(this.btn_RightArrow_Click);
            // 
            // lb_QuestionNum
            // 
            this.lb_QuestionNum.AutoSize = true;
            this.lb_QuestionNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionNum.Location = new System.Drawing.Point(179, 222);
            this.lb_QuestionNum.Name = "lb_QuestionNum";
            this.lb_QuestionNum.Size = new System.Drawing.Size(112, 18);
            this.lb_QuestionNum.TabIndex = 4;
            this.lb_QuestionNum.Text = "Question 1 of n";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(444, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Submit test";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_QuestionLabel
            // 
            this.lb_QuestionLabel.AutoSize = true;
            this.lb_QuestionLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionLabel.Location = new System.Drawing.Point(179, 9);
            this.lb_QuestionLabel.Name = "lb_QuestionLabel";
            this.lb_QuestionLabel.Size = new System.Drawing.Size(113, 18);
            this.lb_QuestionLabel.TabIndex = 6;
            this.lb_QuestionLabel.Text = "[Question here]";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(468, 297);
            this.Controls.Add(this.lb_QuestionLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lb_QuestionNum);
            this.Controls.Add(this.btn_RightArrow);
            this.Controls.Add(this.btn_LeftArrow);
            this.Controls.Add(this.txt_AnswerBox);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AnswerBox;
        private System.Windows.Forms.Button btn_LeftArrow;
        private System.Windows.Forms.Button btn_RightArrow;
        private System.Windows.Forms.Label lb_QuestionNum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_QuestionLabel;
    }
}