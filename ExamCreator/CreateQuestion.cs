using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCreator
{
    public partial class CreateQuestion : Form
    {
        public CreateQuestion()
        {
            InitializeComponent();
        }

        public byte[] byteBLOBData { get; set; }


        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                byteBLOBData = new Byte[fsBLOBFile.Length];

                fsBLOBFile.Read(byteBLOBData, 0, byteBLOBData.Length);

                fsBLOBFile.Close();

                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);

                pb_QuestionImage.Image = Image.FromStream(stmBLOBData);
            }
        }



        private void btn_AddOption_Click(object sender, System.EventArgs e)
        {
            string textOption = txt_OptionText.Text;
            bool isCorrect = cb_Correct.Checked;

            if (isCorrect == false)
            {
                lb_Options.Items.Add(textOption.PadRight(20) + "Incorrect");
            }
            else
            {
                lb_Options.Items.Add(textOption.PadRight(20) + "Correct");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lb_Options.Items.Remove(lb_Options.SelectedItem);
        }

        /*private void btn_SubmitQuestion_Click(object sender, EventArgs e)
        {
            if (txt_QuestionTitle.Text == "" || txt_Question.Text == "" )
            {
                MessageBox.Show("The question must have a title and a question to ask. Make sure that the two top fields have content.");
            }
            else
            {
                ObjectQuery<QuestionTable> filteredProduct = new ObjectQuery<QuestionTable>
                    ("INSERT INTO QuestionTable VALUES"(questiontype, txt_QuestionTitle.Text, privacy, byteBLOBData, txt_Question.Text));
                
            }
        }*/

        private void rb_Public_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_SameSchool_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Private_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}