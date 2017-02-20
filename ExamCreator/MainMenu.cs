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
        private int teacherID;

        /// <summary>
        /// Retrieves the teacherID value from Form1 (the login form)
        /// </summary>
        /// <param name="TeacherID"></param>
        public MainMenuTeacher(int TeacherID)
        {
            teacherID = TeacherID;

            InitializeComponent();
        }

        private void btn_CreateQuestion_Click(object sender, EventArgs e)
        {
            QuestionCreator questioncreator = new QuestionCreator();
            questioncreator.Show();
        }

        /// <summary>
        /// send teacherID value to the CreateATest form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CreateTest_Click(object sender, EventArgs e)
        {
            CreateATest createatest = new CreateATest(teacherID);
            createatest.Show();
        }

        /// <summary>
        /// send teacherID value to the ViewResults form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ViewResults_Click(object sender, EventArgs e)
        {
            ResultsDisplay resultsdisplay = new ResultsDisplay(teacherID);
            resultsdisplay.Show();
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            CreateUser createuser = new CreateUser();
            createuser.Show();
        }
    }
}
