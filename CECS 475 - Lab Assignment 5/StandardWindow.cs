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
    public partial class StandardWindow : Form
    {
        BusinessLayer bLayer = new BusinessLayer();
        IEnumerable<Standard> stdData;
        IEnumerable<Student> stuData;
        bool displayRelatedStudents = false;
        string selectedOperation;

        public StandardWindow()
        {
            InitializeComponent();
        }

        private void StandardWindow_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            outputTextBox.Clear();
            int counter = 1;
            stdData = bLayer.getAllStandards();
            foreach (var ele in stdData)
            {
                outputTextBox.AppendText(counter + ".\tStandard ID: " + ele.StandardId
                                          + "\r\n\tStandard Name: " + ele.StandardName + "\r\n");
                counter++;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        /*

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecord addWindow = new AddRecord(bLayer, "Standard");
            addWindow.Show();
        }
        
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateWindow updtWindow = new UpdateWindow(bLayer, "Standard");
            updtWindow.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteWindow delWindow = new DeleteWindow(bLayer, "Standard");
            delWindow.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchWindow srchWindow = new SearchWindow(bLayer, "Standard");
            srchWindow.Show();
        }
         * */

        private void radioBtnAdd_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = true;
            txtDescription.Enabled = true;
            btnClear.Enabled = true;
            btnSubmit.Enabled = true;
            selectedOperation = "add";
        }

        private void radioBtnUpdate_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtDescription.Enabled = true;
            btnClear.Enabled = true;
            btnSubmit.Enabled = true;
            selectedOperation = "update";
        }

        private void radioBtnDelete_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            btnClear.Enabled = true;
            btnSubmit.Enabled = true;
            selectedOperation = "delete";
        }

        private void radioBtnSearchById_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            btnClear.Enabled = true;
            btnSubmit.Enabled = true;
            selectedOperation = "searchId";
        }

        private void radioBtnSearchByName_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = true;
            txtDescription.Enabled = false;
            btnClear.Enabled = true;
            btnSubmit.Enabled = true;
            selectedOperation = "searchName";
        }

        private void checkBoxRelatedStudents_Click(object sender, EventArgs e)
        {
            if (displayRelatedStudents)
                displayRelatedStudents = false;
            else
                displayRelatedStudents = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtName.Clear();
            txtId.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (selectedOperation == "add")
            {
                Standard std = new Standard();
                int stdId = Int32.Parse(txtId.Text);
                std.StandardName = txtName.Text;
                bLayer.addStandard(std);
                LoadData();
            }/*
            else if (selectedOperation == "update")
            {
                Student stu = new Student();
                int stuId = Int32.Parse(txtId.Text);
                int stdId = Int32.Parse(comboBoxStandard.Text);
                stu.StudentID = stuId;
                stu.StudentName = txtName.Text;
                stu.StandardId = stdId;
                bLayer.UpdateStudent(stu);
                LoadData();
            }
            else if (selectedOperation == "delete")
            {
                int stuId = Int32.Parse(txtId.Text);
                Student stu = bLayer.GetStudentByID(stuId);
                bLayer.RemoveStudent(stu);
                LoadData();
            }
            else if (selectedOperation == "searchById")
            {
                int stuId = Int32.Parse(txtId.Text);
                Student stu = bLayer.GetStudentByID(stuId);
                outputTextBox.Clear();
                outputTextBox.AppendText("Student ID: " + stu.StudentID +
                                         "\r\nStudent Name: " + stu.StudentName +
                                         "\r\nStandard ID: " + stu.StandardId);
            }
            else if (selectedOperation == "searchByName")
            {
                Student stu = bLayer.GetStudentByName(txtName.Text);
                outputTextBox.Clear();
                outputTextBox.AppendText("Student ID: " + stu.StudentID +
                                         "\r\nStudent Name: " + stu.StudentName +
                                         "\r\nStandard ID: " + stu.StandardId);
            }
              * */
        }
    }
}
