namespace ExamCreator
{
    partial class SendTest
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
            this.lb_SendUsers = new System.Windows.Forms.ListBox();
            this.dg_Students = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_AddToList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_SendUsers
            // 
            this.lb_SendUsers.FormattingEnabled = true;
            this.lb_SendUsers.Location = new System.Drawing.Point(13, 13);
            this.lb_SendUsers.Name = "lb_SendUsers";
            this.lb_SendUsers.Size = new System.Drawing.Size(141, 173);
            this.lb_SendUsers.TabIndex = 0;
            // 
            // dg_Students
            // 
            this.dg_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Students.Location = new System.Drawing.Point(160, 13);
            this.dg_Students.Name = "dg_Students";
            this.dg_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Students.Size = new System.Drawing.Size(424, 173);
            this.dg_Students.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(13, 193);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(141, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete User";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_AddToList
            // 
            this.btn_AddToList.Location = new System.Drawing.Point(471, 193);
            this.btn_AddToList.Name = "btn_AddToList";
            this.btn_AddToList.Size = new System.Drawing.Size(113, 23);
            this.btn_AddToList.TabIndex = 3;
            this.btn_AddToList.Text = "Add to send list";
            this.btn_AddToList.UseVisualStyleBackColor = true;
            this.btn_AddToList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Complete and send to users";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SendTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AddToList);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dg_Students);
            this.Controls.Add(this.lb_SendUsers);
            this.Name = "SendTest";
            this.Text = "Send Test";
            this.Load += new System.EventHandler(this.SendTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Students)).EndInit();
            this.ResumeLayout(false);

        }

        private void dg_Public_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox lb_SendUsers;
        private System.Windows.Forms.DataGridView dg_Students;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_AddToList;
        private System.Windows.Forms.Button button1;
    }
}