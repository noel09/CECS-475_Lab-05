/**************************************
 * 
 * George Rhee and Imanuel Kurniawan
 * CECS 475 - Lab Assignment #5
 * MainMenu.cs
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
   public partial class MainMenu : Form
   {
      //Constructor
      public MainMenu()
      {
         InitializeComponent();
      }//end constructor MainMenu

      //Button for Standard menu
      private void btnStandard_Click(object sender, EventArgs e)
      {
         StandardWindow stdWindow = new StandardWindow();
         stdWindow.Show();
      }//end method btnStandard_Click

      //Button for Student menu
      private void btnStudent_Click(object sender, EventArgs e)
      {
         StudentWindow stuWindow = new StudentWindow();
         stuWindow.Show();
      }//end method btnStudent_Click
   }//end class MainMenu
}//end namespace CECS_475___Lab_Assignment_5
