namespace ExamCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionCreator));
            this.btn_SubmitQuestion = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.num_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Difficulty)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SubmitQuestion
            // 
            this.btn_SubmitQuestion.BackColor = System.Drawing.Color.White;
            this.btn_SubmitQuestion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SubmitQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SubmitQuestion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitQuestion.Location = new System.Drawing.Point(180, 144);
            this.btn_SubmitQuestion.Name = "btn_SubmitQuestion";
            this.btn_SubmitQuestion.Size = new System.Drawing.Size(99, 23);
            this.btn_SubmitQuestion.TabIndex = 35;
            this.btn_SubmitQuestion.Text = "Submit question";
            this.btn_SubmitQuestion.UseVisualStyleBackColor = false;
            this.btn_SubmitQuestion.Click += new System.EventHandler(this.btn_SubmitQuestion_Click);
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
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Question title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
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
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Difficulty";
            // 
            // tbar_Difficulty
            // 
            this.tbar_Difficulty.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(295, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 158);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Topic";
            // 
            // lb_Topics
            // 
            this.lb_Topics.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Topics.FormattingEnabled = true;
            this.lb_Topics.ItemHeight = 14;
            this.lb_Topics.Items.AddRange(new object[] {
            "Databases",
            "Algorithims",
            "Binary",
            "Hardware",
            "Software",
            "Networks"});
            this.lb_Topics.Location = new System.Drawing.Point(7, 20);
            this.lb_Topics.Name = "lb_Topics";
            this.lb_Topics.Size = new System.Drawing.Size(254, 130);
            this.lb_Topics.TabIndex = 0;
            // 
            // QuestionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(570, 177);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tbar_Difficulty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Mark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SubmitQuestion);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.txt_QuestionTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionCreator";
            this.Text = "Question Creator";
            this.Load += new System.EventHandler(this.QuestionCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Difficulty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SubmitQuestion;
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