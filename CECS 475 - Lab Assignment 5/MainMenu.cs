using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CECS_475___Lab_Assignment_5
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            StandardWindow stdWindow = new StandardWindow();
            stdWindow.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentWindow stuWindow = new StudentWindow();
            stuWindow.Show();
        }
    }
}
