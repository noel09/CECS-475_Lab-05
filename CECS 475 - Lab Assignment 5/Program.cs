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

         BusinessLayer bs = new BusinessLayer();
         Standard stan = new Standard();
         Student stud = new Student();

         int classChoice;
         int menuChoice;

         int id;
         string name;

         bool quit = false;

         while (!quit)
         {
            Console.WriteLine("Which class would you like to see?");
            Console.WriteLine("  1. Standard");
            Console.WriteLine("  2. Student");

            classChoice = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Choose an menu option:");
            Console.WriteLine("  1. Create");
            Console.WriteLine("  2. Update");
            Console.WriteLine("  3. Delete");
            Console.WriteLine("  4. Search by ID");
            Console.WriteLine("  5. Search by Name");
            Console.WriteLine("  6. Display All");
            Console.WriteLine("  7. Student with StandardID");
            Console.WriteLine("  8. Quit");

            menuChoice = Int32.Parse(Console.ReadLine());
            switch (menuChoice)
            {
               //create
               case 1:
                  if (classChoice == 1)
                  {
                     Console.WriteLine("What name?");
                     name = Console.ReadLine();
                     stan.StandardName = name;
                     bs.addStandard(stan);
                  }
                  else
                  {
                     Console.WriteLine("What StandardID?");
                     id = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("What name?");
                     name = Console.ReadLine();
                     stud.StandardId = id;
                     stud.StudentName = name;
                     bs.addStudent(stud);
                  }
                  break;
               //update
               case 2:
                  if (classChoice == 1)
                  {
                     Console.WriteLine("What ID?");
                     id = Int32.Parse(Console.ReadLine());
                     stan = bs.GetStandardByID(id);
                     Console.WriteLine("Change {0} to new name:", stan.StandardName);
                     name = Console.ReadLine();
                     stan.StandardName = name;
                     bs.updateStandard(stan);
                  }
                  else
                  {
                     Console.WriteLine("What ID?");
                     id = Int32.Parse(Console.ReadLine());
                     stud = bs.GetStudentByID(id);
                     Console.WriteLine("Change {0} to new name:", stud.StudentName);
                     name = Console.ReadLine();
                     stud.StudentName = name;
                     bs.UpdateStudent(stud);
                  }
                  break;
               //delete
               case 3:
                  if (classChoice == 1)
                  {
                     Console.WriteLine("What ID?");
                     id = Int32.Parse(Console.ReadLine());
                     stan = bs.GetStandardByID(id);
                     Console.WriteLine("Delete {0}? y/n", stan.StandardName);
                     name = Console.ReadLine();
                     if (name.Equals("y"))
                     {
                        bs.removeStandard(stan);
                     }
                  }
                  else
                  {
                     Console.WriteLine("What ID?");
                     id = Int32.Parse(Console.ReadLine());
                     stud = bs.GetStudentByID(id);
                     Console.WriteLine("Delete {0}? y/n", stud.StudentName);
                     name = Console.ReadLine();
                     if (name.Equals("y"))
                     {
                        bs.RemoveStudent(stud);
                     }
                  }
                  break;
               //id
               case 4:
                  Console.WriteLine("What ID?");
                  id = Int32.Parse(Console.ReadLine());
                  if (classChoice == 1)
                  {
                     stan = bs.GetStandardByID(id);
                     Console.WriteLine("ID: {0}, Name: {1}", stan.StandardId, stan.StandardName);
                  }
                  else
                  {
                     stud = bs.GetStudentByID(id);
                     Console.WriteLine("ID: {0}, Name: {1}", stud.StudentID, stud.StudentName);
                  }
                  break;
               //name
               case 5:
                  Console.WriteLine("What name?");
                  name = Console.ReadLine();
                  if (classChoice == 1)
                  {
                     stan = bs.GetStandardByName(name);
                     Console.WriteLine("ID: {0}, Name: {1}", stan.StandardId, stan.StandardName);
                  }
                  else
                  {
                     stud = bs.GetStudentByName(name);
                     Console.WriteLine("ID: {0}, Name: {1}", stud.StudentID, stud.StudentName);
                  }
                  break;
               //display
               case 6:
                  if (classChoice == 1)
                  {
                     IEnumerable<Standard> data = bs.getAllStandards();
                     foreach (var e in data)
                     {
                        Console.WriteLine("ID: {0}, Name: {1}", e.StandardId, e.StandardName);
                     }
                  }
                  else
                  {
                     IEnumerable<Student> data = bs.getAllStudents();
                     foreach (var e in data)
                     {
                        Console.WriteLine("ID: {0}, Name: {1}, StandardID: {2}", e.StudentID, e.StudentName, e.StandardId);
                     }
                  }
                  break;
               //student by standardID
               case 7:
                  if (classChoice == 1)
                  {
                     Console.WriteLine("What ID?");
                     id = Int32.Parse(Console.ReadLine());
                     IEnumerable<Student> students = bs.GetStudentByStandardID(id);
                     foreach(var e in students)
                     {
                        Console.WriteLine("ID: {0}, Name: {1}", e.StudentID, e.StudentName);
                     }
                  }
                  else
                  {
                     Console.WriteLine("Student does not have another Student");
                  }
                  break;
               //quit
               default:
                  quit = true;
                  break;
            }
         }

         //Application.EnableVisualStyles();
         //Application.SetCompatibleTextRenderingDefault(false);
         //Application.Run(new MainMenu());
      }
   }
}
