using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCreator
{
    class TestButton : Button //Represents this class as a windows button control.
    {
        //Set the test ID value for the button object in the form
        private int testID;
        public int TestId
        {
            get { return testID; }
            set { testID = value; }
        }

        //Set the studenttest ID value for the button object in the form
        private int studentTestID;
        public int StudentTestID
        {
            get { return studentTestID; }
            set { studentTestID = value; }
        }
        //Set the student ID value for the button object in the form
        private int studentID;
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
    }
}
