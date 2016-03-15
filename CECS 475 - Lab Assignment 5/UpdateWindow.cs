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
    public partial class UpdateWindow : Form
    {
        BusinessLayer bObj;
        String type;

        public UpdateWindow(BusinessLayer bObjPar, String sender)
        {
            bObj = bObjPar;
            type = sender;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtId.Text != null)
            {
                if (txtName.Text != null)
                {
                    if (type == "Standard")
                    {
                        Standard temp = new Standard();
                        temp.StandardId = Int32.Parse(txtId.Text);
                        temp.StandardName = txtName.Text;
                        bObj.updateStandard(temp);
                    }
                    else
                    {
                        Student temp = new Student();
                        temp.StudentID = Int32.Parse(txtId.Text);
                        temp.StudentName = txtName.Text;
                        bObj.UpdateStudent(temp);
                    }
                    this.Close();
                }
                else
                {
                    txtName.Text = "Name can't be blank.";
                }
            }
            else
            {
                txtId.Text = "ID can't be blank.";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
