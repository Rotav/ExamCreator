using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCreator
{
    class TestButton : Button 
    {
        private int testID;
        public int TestId
        {
            get { return testID; }
            set { testID = value; }
        }

        private int studentTestID;
        public int StudentTestID
        {
            get { return studentTestID; }
            set { studentTestID = value; }
        }

        private int studentID;
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
    }
}
