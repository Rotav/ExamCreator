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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Public = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tp_Private = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.examDataSet1 = new ExamCreator.ExamDataSet();
            this.rb_Public = new System.Windows.Forms.RadioButton();
            this.rb_Private = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.txt_Title.Location = new System.Drawing.Point(65, 19);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(237, 20);
            this.txt_Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // btn_CreateTest
            // 
            this.btn_CreateTest.Location = new System.Drawing.Point(227, 45);
            this.btn_CreateTest.Name = "btn_CreateTest";
            this.btn_CreateTest.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateTest.TabIndex = 2;
            this.btn_CreateTest.Text = "Create";
            this.btn_CreateTest.UseVisualStyleBackColor = true;
            this.btn_CreateTest.Click += new System.EventHandler(this.btn_CreateTest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_Private);
            this.groupBox1.Controls.Add(this.rb_Public);
            this.groupBox1.Controls.Add(this.txt_Title);
            this.groupBox1.Controls.Add(this.btn_CreateTest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load test";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tp_Public.Location = new System.Drawing.Point(4, 22);
            this.tp_Public.Name = "tp_Public";
            this.tp_Public.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Public.Size = new System.Drawing.Size(395, 190);
            this.tp_Public.TabIndex = 0;
            this.tp_Public.Text = "Public";
            this.tp_Public.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tp_Private
            // 
            this.tp_Private.Controls.Add(this.dataGridView2);
            this.tp_Private.Location = new System.Drawing.Point(4, 22);
            this.tp_Private.Name = "tp_Private";
            this.tp_Private.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Private.Size = new System.Drawing.Size(395, 190);
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
            // rb_Public
            // 
            this.rb_Public.AutoSize = true;
            this.rb_Public.Checked = true;
            this.rb_Public.Location = new System.Drawing.Point(133, 93);
            this.rb_Public.Name = "rb_Public";
            this.rb_Public.Size = new System.Drawing.Size(54, 17);
            this.rb_Public.TabIndex = 3;
            this.rb_Public.TabStop = true;
            this.rb_Public.Text = "Public";
            this.rb_Public.UseVisualStyleBackColor = true;
            // 
            // rb_Private
            // 
            this.rb_Private.AutoSize = true;
            this.rb_Private.Location = new System.Drawing.Point(193, 93);
            this.rb_Private.Name = "rb_Private";
            this.rb_Private.Size = new System.Drawing.Size(58, 17);
            this.rb_Private.TabIndex = 4;
            this.rb_Private.Text = "Private";
            this.rb_Private.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test privacy";
            // 
            // CreateATest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateATest";
            this.Text = "Create or load a test";
            this.Load += new System.EventHandler(this.CreateATest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
    }
}