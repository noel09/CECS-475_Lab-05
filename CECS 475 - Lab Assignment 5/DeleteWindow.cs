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
    public partial class DeleteWindow : Form
    {
        BusinessLayer bObj;
        String type;

        public DeleteWindow(BusinessLayer bObjPar, String sender)
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
                        Standard temp = bObj.GetStandardByID(Int32.Parse(txtId.Text));
                        bObj.removeStandard(temp);
                    }
                    else
                    {
                        Student temp = bObj.GetStudentByID(Int32.Parse(txtId.Text));
                        bObj.RemoveStudent(temp);
                    }
                    this.Close();
            }
            else
            {
                txtId.Text = "ID can't be blank.";
            }
        }
    }
}
