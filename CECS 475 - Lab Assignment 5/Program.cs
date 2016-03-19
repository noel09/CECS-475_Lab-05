/**************************************
 * 
 * George Rhee and Imanuel Kurniawan
 * CECS 475 - Lab Assignment #5
 * Program.cs
 * 
 * ************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CECS_475___Lab_Assignment_5
{
   class Program
   {
      static void Main(string[] args)
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainMenu());

      }//end method Main
   }//end class Program
}//end namespace CECS_475___Lab_Assignment_5
