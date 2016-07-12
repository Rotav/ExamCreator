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
    public partial class MainMenuStudent : Form
    {
        public MainMenuStudent()
        {
            InitializeComponent();
            AddTests();
        }

        private void AddTests()
        {
            int i = 1;

            foreach (TabPage tab in tb_Menu.TabPages)
            {
                string query = "SELECT VALUE a FROM tblTest WHERE a.Id = " + i.ToString();

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;

                foreach (tblTests test in query)
                {
                    Button button = new Button();
                    button.Size = new Size(250, 50);
                    button.Text = test.TestTitle + "    " + test.Description;
                    flp.Controls.Add(button);
                }

                tab.Controls.Add(flp);
                i++;
            }
        }
    }
}
