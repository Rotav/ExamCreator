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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Menu = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click a test below to begin a test";
            // 
            // tb_Menu
            // 
            this.tb_Menu.Location = new System.Drawing.Point(15, 30);
            this.tb_Menu.Name = "tb_Menu";
            this.tb_Menu.SelectedIndex = 0;
            this.tb_Menu.Size = new System.Drawing.Size(360, 205);
            this.tb_Menu.TabIndex = 0;
            // 
            // MainMenuStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(383, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuStudent";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tb_Menu;
    }
}