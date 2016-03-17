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
    public partial class StudentWindow : Form
    {
        BusinessLayer bLayer = new BusinessLayer();
        IEnumerable<Student> stuData;

        public StudentWindow()
        {
            InitializeComponent();
        }

        private void StudentWindow_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            outputTextBox.Clear();
            int counter = 1;
            stuData = bLayer.getAllStudents();
            foreach (var ele in stuData)
            {
                outputTextBox.AppendText(counter + ".\tStandard ID: " + ele.StudentID
                                          + "\r\n\tStandard Name: " + ele.StudentName + "\r\n");
                counter++;
            }
        }

        private void radioBtnAdd_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = true;
            comboBoxStandard.Enabled = true;
            btnClear.Enabled = true;
            btnSubmit.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecord addWindow = new AddRecord(bLayer, "Student");
            addWindow.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateWindow updtWindow = new UpdateWindow(bLayer, "Student");
            updtWindow.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteWindow delWindow = new DeleteWindow(bLayer, "Student");
            delWindow.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchWindow srchWindow = new SearchWindow(bLayer, "Student");
            srchWindow.Show();
        }
         * */
    }
}
