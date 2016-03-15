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
    public partial class SearchWindow : Form
    {
        BusinessLayer bObj;
        String type;

        public SearchWindow(BusinessLayer bObjPar, String sender)
        {
            bObj = bObjPar;
            type = sender;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtId.Text != null)
            {
                if (type == "Standard")
                {
                    outputTextBox.Clear();
                    Standard temp = bObj.GetStandardByID(Int32.Parse(txtId.Text));
                    outputTextBox.AppendText("Standard ID: " + temp.StandardId +
                                             "\r\nStandard Name: " + temp.StandardName);
                }
                else
                {
                    outputTextBox.Clear();
                    Student temp = bObj.GetStudentByID(Int32.Parse(txtId.Text));
                    outputTextBox.AppendText("Standard ID: " + temp.StudentID +
                                             "\r\nStandard Name: " + temp.StudentName);
                }
            }
            else
            {
                txtId.Text = "ID can't be blank.";
            }
        }
    }
}
