namespace ExamCreator
{
    partial class MainMenuStudent
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
            this.tb_Menu = new System.Windows.Forms.TabControl();
            this.tb_Tests = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Menu
            // 
            this.tb_Menu.Controls.Add(this.tb_Tests);
            this.tb_Menu.Controls.Add(this.tabPage2);
            this.tb_Menu.Location = new System.Drawing.Point(12, 102);
            this.tb_Menu.Name = "tb_Menu";
            this.tb_Menu.SelectedIndex = 0;
            this.tb_Menu.Size = new System.Drawing.Size(360, 205);
            this.tb_Menu.TabIndex = 0;
            // 
            // tb_Tests
            // 
            this.tb_Tests.Location = new System.Drawing.Point(4, 22);
            this.tb_Tests.Name = "tb_Tests";
            this.tb_Tests.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Tests.Size = new System.Drawing.Size(352, 179);
            this.tb_Tests.TabIndex = 0;
            this.tb_Tests.Text = "Tests";
            this.tb_Tests.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainMenuStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 319);
            this.Controls.Add(this.tb_Menu);
            this.Name = "MainMenuStudent";
            this.Text = "Main Menu";
            this.tb_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_Menu;
        private System.Windows.Forms.TabPage tb_Tests;
        private System.Windows.Forms.TabPage tabPage2;
    }
}