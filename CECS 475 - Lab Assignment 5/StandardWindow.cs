/**************************************
 * 
 * George Rhee and Imanuel Kurniawan
 * CECS 475 - Lab Assignment #5
 * StandardWindow.cs
 * 
 * ************************************/

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

      //Constructor
      public StandardWindow()
      {
         InitializeComponent();
      }//end constructor StandardWindow

      private void StandardWindow_Load(object sender, EventArgs e)
      {
         LoadData();
      }//end method StandardWindow_Load

      private void LoadData()
      {
         outputTextBox.Clear();
         int counter = 1;
         stdData = bLayer.getAllStandards();
         foreach (var ele in stdData)
         {
            outputTextBox.AppendText(counter + ".\tStandard ID: " + ele.StandardId
                                      + "\r\n\tStandard Name: " + ele.StandardName + "\r\n");
            if (displayRelatedStudents)
            {
               outputTextBox.AppendText("\tRelated Students: \r\n");
               stuData = bLayer.GetStudentByStandardID(ele.StandardId);
               foreach (var ele2 in stuData)
               {
                  outputTextBox.AppendText("\t\tStudent ID: " + ele2.StudentID +
                                              "\r\n\t\tStudent Name: " + ele2.StudentName + "\r\n");
               }
            }
            counter++;
         }
      }//end method LoadData

      private void btnRefresh_Click(object sender, EventArgs e)
      {
         clearAllFields();
         LoadData();
      }//end method btnRefresh_Click

      private void radioBtnAdd_Click(object sender, EventArgs e)
      {
         txtId.Enabled = false;
         txtName.Enabled = true;
         txtDescription.Enabled = true;
         btnClear.Enabled = true;
         btnSubmit.Enabled = true;
         selectedOperation = "add";
         clearAllFields();
      }//end method radioBtnAdd_Click

      private void radioBtnUpdate_Click(object sender, EventArgs e)
      {
         txtId.Enabled = true;
         txtName.Enabled = true;
         txtDescription.Enabled = true;
         btnClear.Enabled = true;
         btnSubmit.Enabled = true;
         selectedOperation = "update";
         clearAllFields();
      }//end method radioBtnUpdate_Click

      private void radioBtnDelete_Click(object sender, EventArgs e)
      {
         txtId.Enabled = true;
         txtName.Enabled = false;
         txtDescription.Enabled = false;
         btnClear.Enabled = true;
         btnSubmit.Enabled = true;
         selectedOperation = "delete";
         clearAllFields();
      }//end method radioBtnDelete_Click

      private void radioBtnSearchById_Click(object sender, EventArgs e)
      {
         txtId.Enabled = true;
         txtName.Enabled = false;
         txtDescription.Enabled = false;
         btnClear.Enabled = true;
         btnSubmit.Enabled = true;
         selectedOperation = "searchById";
         clearAllFields();
      }//end method radioBtnSearchById_Click

      private void radioBtnSearchByName_Click(object sender, EventArgs e)
      {
         txtId.Enabled = false;
         txtName.Enabled = true;
         txtDescription.Enabled = false;
         btnClear.Enabled = true;
         btnSubmit.Enabled = true;
         selectedOperation = "searchByName";
         clearAllFields();
      }//end method radioBtnSearchByName_Click

      private void checkBoxRelatedStudents_Click(object sender, EventArgs e)
      {
         if (displayRelatedStudents)
            displayRelatedStudents = false;
         else
            displayRelatedStudents = true;
      }//end method checkBoxRelatedStudents_Click

      private void btnClear_Click(object sender, EventArgs e)
      {
         clearAllFields();
      }//end method btnClear_Click

      private void btnSubmit_Click(object sender, EventArgs e)
      {
         Standard std;
         int stdId;
         switch (selectedOperation)
         {
            case "add":
               std = new Standard();
               std.StandardName = txtName.Text;
               std.Description = txtDescription.Text;
               bLayer.addStandard(std);
               LoadData();
               break;
            case "update":
               stdId = Int32.Parse(txtId.Text);
               std = bLayer.GetStandardByID(stdId);
               std.StandardName = txtName.Text;
               std.Description = txtDescription.Text;
               bLayer.updateStandard(std);
               LoadData();
               break;
            case "delete":
               stdId = Int32.Parse(txtId.Text);
               std = bLayer.GetStandardByID(stdId);
               bLayer.removeStandard(std);
               LoadData();
               break;
            case "searchById":
               stdId = Int32.Parse(txtId.Text);
               std = bLayer.GetStandardByID(stdId);
               outputTextBox.Clear();
               outputTextBox.AppendText("Standard ID: " + std.StandardId +
                                        "\r\nStandard Name: " + std.StandardName +
                                        "\r\nDescription: " + std.Description + "\r\n");
               if (displayRelatedStudents)
               {
                  outputTextBox.AppendText("Related Students: \r\n");
                  stuData = bLayer.GetStudentByStandardID(stdId);
                  foreach (var ele in stuData)
                  {
                     outputTextBox.AppendText("\tStudent ID: " + ele.StudentID +
                                              "\r\n\tStudent Name: " + ele.StudentName + "\r\n");
                  }
               }
               break;
            case "searchByName":
               std = bLayer.GetStandardByName(txtName.Text);
               outputTextBox.Clear();
               outputTextBox.AppendText("Standard ID: " + std.StandardId +
                                        "\r\nStandard Name: " + std.StandardName +
                                        "\r\nDescription: " + std.Description + "\r\n");
               if (displayRelatedStudents)
               {
                  outputTextBox.AppendText("Related Students: \r\n");
                  stuData = bLayer.GetStudentByStandardID(std.StandardId);
                  foreach (var ele in stuData)
                  {
                     outputTextBox.AppendText("\tStudent ID: " + ele.StudentID +
                                              "\r\n\tStudent Name: " + ele.StudentName + "\r\n");
                  }
               }
               break;
            default:
               break;
         }
         clearAllFields();
      }//end method btnSubmit_Click

      //Method to clear all textfields
      public void clearAllFields()
      {
         txtId.Clear();
         txtName.Clear();
         txtDescription.Clear();
      }//end method clearAllFields
   }//end class StandardWindow
}//end namespace CECS_475___Lab_Assignment_5
