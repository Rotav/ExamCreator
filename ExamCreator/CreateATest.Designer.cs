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
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateTest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_AS = new System.Windows.Forms.RadioButton();
            this.rb_A2 = new System.Windows.Forms.RadioButton();
            this.rb_GCSE = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_Private = new System.Windows.Forms.RadioButton();
            this.rb_Public = new System.Windows.Forms.RadioButton();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Public = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tp_Private = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.examDataSet1 = new ExamCreator.ExamDataSet();
            this.cb_Level = new System.Windows.Forms.ComboBox();
            this.lb_Filter = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_Public.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tp_Private.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(98, 27);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(311, 20);
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
            this.btn_CreateTest.Location = new System.Drawing.Point(330, 153);
            this.btn_CreateTest.Name = "btn_CreateTest";
            this.btn_CreateTest.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateTest.TabIndex = 2;
            this.btn_CreateTest.Text = "Create";
            this.btn_CreateTest.UseVisualStyleBackColor = false;
            this.btn_CreateTest.Click += new System.EventHandler(this.btn_CreateTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Title);
            this.groupBox1.Controls.Add(this.btn_CreateTest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create test";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_AS);
            this.panel2.Controls.Add(this.rb_A2);
            this.panel2.Controls.Add(this.rb_GCSE);
            this.panel2.Location = new System.Drawing.Point(98, 152);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_Private);
            this.panel1.Controls.Add(this.rb_Public);
            this.panel1.Location = new System.Drawing.Point(98, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 24);
            this.panel1.TabIndex = 12;
            // 
            // rb_Private
            // 
            this.rb_Private.AutoSize = true;
            this.rb_Private.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rb_Private.Location = new System.Drawing.Point(62, 3);
            this.rb_Private.Name = "rb_Private";
            this.rb_Private.Size = new System.Drawing.Size(58, 18);
            this.rb_Private.TabIndex = 4;
            this.rb_Private.Text = "Private";
            this.rb_Private.UseVisualStyleBackColor = true;
            this.rb_Private.CheckedChanged += new System.EventHandler(this.rb_Private_CheckedChanged);
            // 
            // rb_Public
            // 
            this.rb_Public.AutoSize = true;
            this.rb_Public.Checked = true;
            this.rb_Public.Font = new System.Drawing.Font("Arial", 8.25F);
            this.rb_Public.Location = new System.Drawing.Point(3, 3);
            this.rb_Public.Name = "rb_Public";
            this.rb_Public.Size = new System.Drawing.Size(53, 18);
            this.rb_Public.TabIndex = 3;
            this.rb_Public.TabStop = true;
            this.rb_Public.Text = "Public";
            this.rb_Public.UseVisualStyleBackColor = true;
            this.rb_Public.CheckedChanged += new System.EventHandler(this.rb_Public_CheckedChanged);
            // 
            // txt_Description
            // 
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
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Test level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.Location = new System.Drawing.Point(7, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test privacy";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_Filter);
            this.groupBox2.Controls.Add(this.cb_Level);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load test";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(334, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Public);
            this.tabControl1.Controls.Add(this.tp_Private);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 216);
            this.tabControl1.TabIndex = 5;
            // 
            // tp_Public
            // 
            this.tp_Public.Controls.Add(this.dataGridView1);
            this.tp_Public.Location = new System.Drawing.Point(4, 23);
            this.tp_Public.Name = "tp_Public";
            this.tp_Public.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Public.Size = new System.Drawing.Size(395, 189);
            this.tp_Public.TabIndex = 0;
            this.tp_Public.Text = "Public";
            this.tp_Public.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tp_Private
            // 
            this.tp_Private.Controls.Add(this.dataGridView2);
            this.tp_Private.Location = new System.Drawing.Point(4, 23);
            this.tp_Private.Name = "tp_Private";
            this.tp_Private.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Private.Size = new System.Drawing.Size(395, 189);
            this.tp_Private.TabIndex = 2;
            this.tp_Private.Text = "Private";
            this.tp_Private.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(383, 178);
            this.dataGridView2.TabIndex = 1;
            // 
            // examDataSet1
            // 
            this.examDataSet1.DataSetName = "ExamDataSet";
            this.examDataSet1.Locale = new System.Globalization.CultureInfo("en-GB");
            this.examDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_Level
            // 
            this.cb_Level.FormattingEnabled = true;
            this.cb_Level.Location = new System.Drawing.Point(121, 243);
            this.cb_Level.Name = "cb_Level";
            this.cb_Level.Size = new System.Drawing.Size(124, 22);
            this.cb_Level.TabIndex = 7;
            // 
            // lb_Filter
            // 
            this.lb_Filter.AutoSize = true;
            this.lb_Filter.Font = new System.Drawing.Font("Arial", 13F);
            this.lb_Filter.Location = new System.Drawing.Point(12, 243);
            this.lb_Filter.Name = "lb_Filter";
            this.lb_Filter.Size = new System.Drawing.Size(103, 21);
            this.lb_Filter.TabIndex = 8;
            this.lb_Filter.Text = "Level Filter:";
            // 
            // CreateATest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateATest";
            this.Text = "Create or load a test";
            this.Load += new System.EventHandler(this.CreateATest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_Public.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tp_Private.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Public;
        private System.Windows.Forms.TabPage tp_Private;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ExamDataSet examDataSet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_Private;
        private System.Windows.Forms.RadioButton rb_Public;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_A2;
        private System.Windows.Forms.RadioButton rb_AS;
        private System.Windows.Forms.RadioButton rb_GCSE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Filter;
        private System.Windows.Forms.ComboBox cb_Level;
    }
}