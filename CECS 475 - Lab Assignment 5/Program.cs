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
            /*
            String strTemp;
            int id;

            BusinessLayer bs = new BusinessLayer();
            Standard temp = new Standard();
            Console.Write("Enter the ID: ");
            strTemp = Console.ReadLine();
            id = Int32.Parse(strTemp);
            temp = bs.GetStandardByID(id);
            Console.WriteLine("Old Name: " + temp.StandardName);
            Console.Write("Enter the New Name: ");
            strTemp = Console.ReadLine();

            temp.StandardId = id;
            temp.StandardName = strTemp;

            bs.updateStandard(temp);

            //bs.addStandard(temp);

            //bs.removeStandard(temp);


            
            IEnumerable<Standard> stdData = bs.getAllStandards();

            Console.WriteLine("\nLIST OF ALL STANDARDS\n");

            foreach (var e in stdData)
            {
                Console.WriteLine("Standard ID: " + e.StandardId);
                Console.WriteLine("\tStandard Name: " + e.StandardName);
            }
             
         
            /*
            Standard std = bs.GetStandardByID(5);
            Console.WriteLine(std.StandardName);
             * */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
            
        }
    }
}
