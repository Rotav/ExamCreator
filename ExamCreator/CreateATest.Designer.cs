namespace ExamCreator
{
    partial class CreateATest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateATest));
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_AS = new System.Windows.Forms.RadioButton();
            this.rb_A2 = new System.Windows.Forms.RadioButton();
            this.rb_GCSE = new System.Windows.Forms.RadioButton();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.examDataSet1 = new ExamCreator.ExamDataSet();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(98, 27);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(311, 25);
            this.txt_Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // btn_CreateTest
            // 
            this.btn_CreateTest.BackColor = System.Drawing.Color.White;
            this.btn_CreateTest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CreateTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreateTest.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateTest.Location = new System.Drawing.Point(338, 125);
            this.btn_CreateTest.Name = "btn_CreateTest";
            this.btn_CreateTest.Size = new System.Drawing.Size(71, 23);
            this.btn_CreateTest.TabIndex = 2;
            this.btn_CreateTest.Text = "Create";
            this.btn_CreateTest.UseVisualStyleBackColor = false;
            this.btn_CreateTest.Click += new System.EventHandler(this.btn_CreateTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Title);
            this.groupBox1.Controls.Add(this.btn_CreateTest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create test";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_AS);
            this.panel2.Controls.Add(this.rb_A2);
            this.panel2.Controls.Add(this.rb_GCSE);
            this.panel2.Location = new System.Drawing.Point(98, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 23);
            this.panel2.TabIndex = 13;
            // 
            // rb_AS
            // 
            this.rb_AS.AutoSize = true;
            this.rb_AS.Checked = true;
            this.rb_AS.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rb_AS.Location = new System.Drawing.Point(3, 3);
            this.rb_AS.Name = "rb_AS";
            this.rb_AS.Size = new System.Drawing.Size(40, 18);
            this.rb_AS.TabIndex = 6;
            this.rb_AS.TabStop = true;
            this.rb_AS.Text = "AS";
            this.rb_AS.UseVisualStyleBackColor = true;
            // 
            // rb_A2
            // 
            this.rb_A2.AutoSize = true;
            this.rb_A2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rb_A2.Location = new System.Drawing.Point(49, 3);
            this.rb_A2.Name = "rb_A2";
            this.rb_A2.Size = new System.Drawing.Size(39, 18);
            this.rb_A2.TabIndex = 7;
            this.rb_A2.Text = "A2";
            this.rb_A2.UseVisualStyleBackColor = true;
            // 
            // rb_GCSE
            // 
            this.rb_GCSE.AutoSize = true;
            this.rb_GCSE.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rb_GCSE.Location = new System.Drawing.Point(94, 3);
            this.rb_GCSE.Name = "rb_GCSE";
            this.rb_GCSE.Size = new System.Drawing.Size(53, 18);
            this.rb_GCSE.TabIndex = 9;
            this.rb_GCSE.Text = "GCSE";
            this.rb_GCSE.UseVisualStyleBackColor = true;
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(98, 53);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(311, 63);
            this.txt_Description.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Test level";
            // 
            // examDataSet1
            // 
            this.examDataSet1.DataSetName = "ExamDataSet";
            this.examDataSet1.Locale = new System.Globalization.CultureInfo("en-GB");
            this.examDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreateATest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 182);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateATest";
            this.Text = "Create a test";
            this.Load += new System.EventHandler(this.CreateATest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private ExamDataSet examDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_A2;
        private System.Windows.Forms.RadioButton rb_AS;
        private System.Windows.Forms.RadioButton rb_GCSE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Panel panel2;
    }
}