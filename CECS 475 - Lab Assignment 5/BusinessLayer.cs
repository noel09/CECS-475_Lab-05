/**************************************
 * 
 * George Rhee and Imanuel Kurniawan
 * CECS 475 - Lab Assignment #5
 * BusinessLayer.cs
 * 
 * ************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CECS_475___Lab_Assignment_5
{
   public interface IBusinessLayer
   {
      IEnumerable<Standard> getAllStandards();
      Standard GetStandardByID(int id);
      void addStandard(Standard standardObj);
      void updateStandard(Standard standardObj);
      void removeStandard(Standard standardObj);
      IEnumerable<Student> getAllStudents();
      Student GetStudentByID(int id);
      void addStudent(Student studentObj);
      void UpdateStudent(Student studentObj);
      void RemoveStudent(Student studentObj);
      Standard GetStandardByName(string name);
      Student GetStudentByName(string name);
      IEnumerable<Student> GetStudentByStandardID(int id);
   }//end interface IBusinessLayer

   public class BusinessLayer : IBusinessLayer
   {
      private readonly IStandardRepository _standardRepository;
      private readonly IStudentRepository _studentRepository;

      //Constructor
      public BusinessLayer()
      {
         _standardRepository = new StandardRepository();
         _studentRepository = new StudentRepository();
      }//constructor

      //Add new Standard into repository
      public void addStandard(Standard standardObj)
      {
         _standardRepository.Insert(standardObj);
      }//end addStandard

      //Delete existing Standard from repository
      public void removeStandard(Standard standardObj)
      {
         try
         {
            _standardRepository.Delete(standardObj);
         }
         catch (InvalidOperationException e)
         {
            Console.WriteLine(standardObj.StandardName + " is not in the database.");
         }
      }//end removeStandard

      //Change existing Standard in repository
      public void updateStandard(Standard standardObj)
      {
         _standardRepository.Update(standardObj);
      }//end updateStandard

      //Get all Standards in repository
      public IEnumerable<Standard> getAllStandards()
      {
         return _standardRepository.GetAll();
      }//end getAllStandards

      //Get Standard with integer
      public Standard GetStandardByID(int id)
      {
         return _standardRepository.GetById(id);
      }//end GetStandardByID

      //Get all Students in repository
      public IEnumerable<Student> getAllStudents()
      {
         return _studentRepository.GetAll();
      }//end getAllStudents

      //Get Student with integer
      public Student GetStudentByID(int id)
      {
         return _studentRepository.GetById(id);
      }//end GetStudentByID

      //Add new Student into repository
      public void addStudent(Student studentObj)
      {
         _studentRepository.Insert(studentObj);
      }//end addStudent

      //Change existing Student in repository
      public void UpdateStudent(Student studentObj)
      {
         _studentRepository.Update(studentObj);
      }//end UpdateStudent

      //Delete Student from repository
      public void RemoveStudent(Student studentObj)
      {
         _studentRepository.Delete(studentObj);
      }//end RemoveStudent

      //Get Standard from string
      public Standard GetStandardByName(String name)
      {
         return _standardRepository.GetSingle(d => d.StandardName.Equals(name), d => d.Students);
      }//end GetStandardByName

      //Get Student from string
      public Student GetStudentByName(String name)
      {
         return _studentRepository.GetSingle(d => d.StudentName.Equals(name), d => d.Standard);
      }//end GetStudentByName

      //Get all Students with StandardID
      public IEnumerable<Student> GetStudentByStandardID(int id)
      {
         return _studentRepository.SearchFor(d => d.StandardId == id);
      }//end GetStudentByStandardID
   }//end class BusinessLayer
}//end namespace CECS_475___Lab_Assignment_5