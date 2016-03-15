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
            BusinessLayer bs = new BusinessLayer();
            Standard temp = new Standard();
            temp.StandardId = 7;
            temp.StandardName = "My Standard";

            //bs.updateStandard(temp);

            bs.addStandard(temp);

            //bs.removeStandard(temp);


            
            IEnumerable<Standard> stdData = bs.getAllStandards();

            foreach (var e in stdData)
            {
                Console.WriteLine(e.StandardName);
            }
            /*
            Standard std = bs.GetStandardByID(5);
            Console.WriteLine(std.StandardName);
             * */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu());
            
            
        }
    }
}
