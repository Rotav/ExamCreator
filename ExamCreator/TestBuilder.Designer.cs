namespace ExamCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestBuilder));
            this.lb_QuestionList = new System.Windows.Forms.ListBox();
            this.btn_DeleteQuestionTest = new System.Windows.Forms.Button();
            this.btn_AddQuestion = new System.Windows.Forms.Button();
            this.btn_Complete = new System.Windows.Forms.Button();
            this.dg_Public = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Public)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_QuestionList
            // 
            this.lb_QuestionList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuestionList.FormattingEnabled = true;
            this.lb_QuestionList.ItemHeight = 14;
            this.lb_QuestionList.Location = new System.Drawing.Point(447, 40);
            this.lb_QuestionList.Name = "lb_QuestionList";
            this.lb_QuestionList.Size = new System.Drawing.Size(198, 312);
            this.lb_QuestionList.TabIndex = 10;
            this.lb_QuestionList.SelectedIndexChanged += new System.EventHandler(this.lb_QuestionList_SelectedIndexChanged);
            // 
            // btn_DeleteQuestionTest
            // 
            this.btn_DeleteQuestionTest.BackColor = System.Drawing.Color.White;
            this.btn_DeleteQuestionTest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DeleteQuestionTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteQuestionTest.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteQuestionTest.Location = new System.Drawing.Point(447, 360);
            this.btn_DeleteQuestionTest.Name = "btn_DeleteQuestionTest";
            this.btn_DeleteQuestionTest.Size = new System.Drawing.Size(198, 23);
            this.btn_DeleteQuestionTest.TabIndex = 13;
            this.btn_DeleteQuestionTest.Text = "Delete Question from test";
            this.btn_DeleteQuestionTest.UseVisualStyleBackColor = false;
            this.btn_DeleteQuestionTest.Click += new System.EventHandler(this.btn_DeleteQuestion_Click);
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.BackColor = System.Drawing.Color.White;
            this.btn_AddQuestion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddQuestion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddQuestion.Location = new System.Drawing.Point(12, 358);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(429, 76);
            this.btn_AddQuestion.TabIndex = 14;
            this.btn_AddQuestion.Text = "Add Question to test";
            this.btn_AddQuestion.UseVisualStyleBackColor = false;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // btn_Complete
            // 
            this.btn_Complete.BackColor = System.Drawing.Color.White;
            this.btn_Complete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Complete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Complete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Complete.Location = new System.Drawing.Point(447, 389);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(198, 47);
            this.btn_Complete.TabIndex = 18;
            this.btn_Complete.Text = "Complete and send test";
            this.btn_Complete.UseVisualStyleBackColor = false;
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click);
            // 
            // dg_Public
            // 
            this.dg_Public.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Public.Location = new System.Drawing.Point(12, 12);
            this.dg_Public.Name = "dg_Public";
            this.dg_Public.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Public.Size = new System.Drawing.Size(429, 340);
            this.dg_Public.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Questions in test";
            // 
            // TestBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(652, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Public);
            this.Controls.Add(this.btn_Complete);
            this.Controls.Add(this.btn_AddQuestion);
            this.Controls.Add(this.btn_DeleteQuestionTest);
            this.Controls.Add(this.lb_QuestionList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestBuilder";
            this.Text = "Test Builder";
            this.Load += new System.EventHandler(this.TestBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Public)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_QuestionList;
        private System.Windows.Forms.Button btn_DeleteQuestionTest;
        private System.Windows.Forms.Button btn_AddQuestion;
        private System.Windows.Forms.Button btn_Complete;
        private System.Windows.Forms.DataGridView dg_Public;
        private System.Windows.Forms.Label label1;

    }
}