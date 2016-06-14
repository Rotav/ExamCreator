using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCreator
{
    public partial class MainMenuTeacher : Form
    {
        public MainMenuTeacher()
        {
            InitializeComponent();
        }

        private void btn_CreateQuestion_Click(object sender, EventArgs e)
        {
            QuestionCreator questioncreator = new QuestionCreator();
            questioncreator.Show();
        }

        private void btn_CreateTest_Click(object sender, EventArgs e)
        {
            CreateATest createatest = new CreateATest();
            createatest.Show();
        }
    }
}
