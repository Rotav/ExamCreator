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

    public partial class MarkingForm : Form
    {
        private int testID = 0;
        private int studentTestID = 0;


        public MarkingForm(int TestID, int StudentTestID)
        {
            studentTestID = StudentTestID;
            testID = TestID;
            MessageBox.Show(testID.ToString());

            InitializeComponent();
        }

        private void MarkingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
