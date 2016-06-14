namespace ExamCreator
{
    partial class MainMenuTeacher
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
            this.btn_CreateTest = new System.Windows.Forms.Button();
            this.btn_CreateQuestion = new System.Windows.Forms.Button();
            this.btn_ViewResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateTest
            // 
            this.btn_CreateTest.Location = new System.Drawing.Point(12, 12);
            this.btn_CreateTest.Name = "btn_CreateTest";
            this.btn_CreateTest.Size = new System.Drawing.Size(201, 23);
            this.btn_CreateTest.TabIndex = 0;
            this.btn_CreateTest.Text = "Create or load a test";
            this.btn_CreateTest.UseVisualStyleBackColor = true;
            this.btn_CreateTest.Click += new System.EventHandler(this.btn_CreateTest_Click);
            // 
            // btn_CreateQuestion
            // 
            this.btn_CreateQuestion.Location = new System.Drawing.Point(12, 41);
            this.btn_CreateQuestion.Name = "btn_CreateQuestion";
            this.btn_CreateQuestion.Size = new System.Drawing.Size(201, 23);
            this.btn_CreateQuestion.TabIndex = 1;
            this.btn_CreateQuestion.Text = "Create a question";
            this.btn_CreateQuestion.UseVisualStyleBackColor = true;
            this.btn_CreateQuestion.Click += new System.EventHandler(this.btn_CreateQuestion_Click);
            // 
            // btn_ViewResults
            // 
            this.btn_ViewResults.Location = new System.Drawing.Point(12, 70);
            this.btn_ViewResults.Name = "btn_ViewResults";
            this.btn_ViewResults.Size = new System.Drawing.Size(201, 23);
            this.btn_ViewResults.TabIndex = 3;
            this.btn_ViewResults.Text = "View results";
            this.btn_ViewResults.UseVisualStyleBackColor = true;
            // 
            // MainMenuTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 103);
            this.Controls.Add(this.btn_ViewResults);
            this.Controls.Add(this.btn_CreateQuestion);
            this.Controls.Add(this.btn_CreateTest);
            this.Name = "MainMenuTeacher";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateTest;
        private System.Windows.Forms.Button btn_CreateQuestion;
        private System.Windows.Forms.Button btn_ViewResults;
    }
}