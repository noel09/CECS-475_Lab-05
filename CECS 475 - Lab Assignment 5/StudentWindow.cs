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
            clearAllFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearAllFields();
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
            clearAllFields();
        }

        private void radioBtnDelete_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = false;
            comboBoxStandard.Enabled = false;
            btnSubmit.Enabled = true;
            btnClear.Enabled = true;
            selectedOperation = "delete";
            clearAllFields();
        }

        private void radioBtnSearchById_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtName.Enabled = false;
            comboBoxStandard.Enabled = false;
            btnSubmit.Enabled = true;
            btnClear.Enabled = true;
            selectedOperation = "searchById";
            clearAllFields();
        }

        private void radioBtnSearchByName_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = true;
            comboBoxStandard.Enabled = false;
            btnSubmit.Enabled = true;
            btnClear.Enabled = true;
            selectedOperation = "searchByName";
            clearAllFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int stdId, stuId;
            Student stu;
            switch (selectedOperation) { 
                case "add":
                    stu = new Student();
                    stdId = Int32.Parse(comboBoxStandard.Text);
                    stu.StudentName = txtName.Text;
                    stu.StandardId = stdId;
                    bLayer.addStudent(stu);
                    LoadData();
                    break;
                case "update":
                    stuId = Int32.Parse(txtId.Text);
                    stdId = Int32.Parse(comboBoxStandard.Text);
                    stu = bLayer.GetStudentByID(stuId);
                    stu.StudentName = txtName.Text;
                    stu.StandardId = stdId;
                    bLayer.UpdateStudent(stu);
                    LoadData();
                    break;
                case "delete":
                    stuId = Int32.Parse(txtId.Text);
                    stu = bLayer.GetStudentByID(stuId);
                    bLayer.RemoveStudent(stu);
                    LoadData();
                    break;
                case "searchById":
                    stuId = Int32.Parse(txtId.Text);
                    stu = bLayer.GetStudentByID(stuId);
                    outputTextBox.Clear();
                    outputTextBox.AppendText("Student ID: " + stu.StudentID +
                                             "\r\nStudent Name: " + stu.StudentName +
                                             "\r\nStandard ID: " + stu.StandardId);
                    break;
                case "searchByName":
                    stu = bLayer.GetStudentByName(txtName.Text);
                    outputTextBox.Clear();
                    outputTextBox.AppendText("Student ID: " + stu.StudentID +
                                             "\r\nStudent Name: " + stu.StudentName +
                                             "\r\nStandard ID: " + stu.StandardId);
                    break;
                default:
                    break;
            }
            clearAllFields();
        }

        public void clearAllFields()
        {
            txtId.Clear();
            txtName.Clear();
            comboBoxStandard.Text = "";
        }
    }
}
