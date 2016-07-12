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
            this.tp_GCSE = new System.Windows.Forms.TabPage();
            this.tp_AS = new System.Windows.Forms.TabPage();
            this.tp_A2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Menu
            // 
            this.tb_Menu.Controls.Add(this.tp_GCSE);
            this.tb_Menu.Controls.Add(this.tp_AS);
            this.tb_Menu.Controls.Add(this.tp_A2);
            this.tb_Menu.Location = new System.Drawing.Point(15, 30);
            this.tb_Menu.Name = "tb_Menu";
            this.tb_Menu.SelectedIndex = 0;
            this.tb_Menu.Size = new System.Drawing.Size(360, 205);
            this.tb_Menu.TabIndex = 0;
            // 
            // tp_GCSE
            // 
            this.tp_GCSE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_GCSE.Location = new System.Drawing.Point(4, 22);
            this.tp_GCSE.Name = "tp_GCSE";
            this.tp_GCSE.Padding = new System.Windows.Forms.Padding(3);
            this.tp_GCSE.Size = new System.Drawing.Size(352, 179);
            this.tp_GCSE.TabIndex = 0;
            this.tp_GCSE.Text = "GCSE";
            this.tp_GCSE.UseVisualStyleBackColor = true;
            // 
            // tp_AS
            // 
            this.tp_AS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_AS.Location = new System.Drawing.Point(4, 22);
            this.tp_AS.Name = "tp_AS";
            this.tp_AS.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AS.Size = new System.Drawing.Size(352, 179);
            this.tp_AS.TabIndex = 1;
            this.tp_AS.Text = "AS";
            this.tp_AS.UseVisualStyleBackColor = true;
            // 
            // tp_A2
            // 
            this.tp_A2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_A2.Location = new System.Drawing.Point(4, 22);
            this.tp_A2.Name = "tp_A2";
            this.tp_A2.Padding = new System.Windows.Forms.Padding(3);
            this.tp_A2.Size = new System.Drawing.Size(352, 179);
            this.tp_A2.TabIndex = 2;
            this.tp_A2.Text = "A2";
            this.tp_A2.UseVisualStyleBackColor = true;
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
            // MainMenuStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(508, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Menu);
            this.Name = "MainMenuStudent";
            this.Text = "Main Menu";
            this.tb_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tb_Menu;
        private System.Windows.Forms.TabPage tp_GCSE;
        private System.Windows.Forms.TabPage tp_AS;
        private System.Windows.Forms.TabPage tp_A2;
        private System.Windows.Forms.Label label1;
    }
}