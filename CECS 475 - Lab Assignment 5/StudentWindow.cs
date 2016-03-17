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
        IEnumerable<Standard> stdData;
        string selectedOperation;

        public StudentWindow()
        {
            InitializeComponent();
            stdData = bLayer.getAllStandards();
            foreach(var ele in stdData){
                comboBoxStandard.Items.Add(ele.StandardId);
            }
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
                outputTextBox.AppendText(counter + ".\tStudent ID: " + ele.StudentID
                                          + "\r\n\tStudent Name: " + ele.StudentName
                                          + "\r\n\tStandard ID: " + ele.StandardId + "\r\n");
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
            selectedOperation = "add";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioBtnUpdate_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            comboBoxStandard.Enabled = true;
            btnClear.Enabled = true;
            btnSubmit.Enabled = true;
            selectedOperation = "update";
        }

        private void radioBtnDelete_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = false;
            comboBoxStandard.Enabled = false;
            btnSubmit.Enabled = true;
            btnClear.Enabled = true;
            selectedOperation = "delete";
        }

        private void radioBtnSearchById_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = false;
            comboBoxStandard.Enabled = false;
            btnSubmit.Enabled = true;
            btnClear.Enabled = true;
            selectedOperation = "searchById";
        }

        private void radioBtnSearchByName_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = true;
            comboBoxStandard.Enabled = false;
            btnSubmit.Enabled = true;
            btnClear.Enabled = true;
            selectedOperation = "searchByName";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (selectedOperation == "add")
            {
                Student stu = new Student();
                int stdId = Int32.Parse(comboBoxStandard.Text);
                stu.StudentName = txtName.Text;
                stu.StandardId = stdId;
                bLayer.addStudent(stu);
                LoadData();
            }
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
