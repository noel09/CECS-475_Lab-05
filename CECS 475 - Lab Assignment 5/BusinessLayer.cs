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
    }
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IStandardRepository _standardRepository;
        private readonly IStudentRepository _studentRepository;
        public BusinessLayer()
        {
            _standardRepository = new StandardRepository();
            _studentRepository = new StudentRepository();
        }

        public void addStandard(Standard standardObj)
        {
            _standardRepository.Insert(standardObj);
        }

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
        }

        public void updateStandard(Standard standardObj)
        {
            _standardRepository.Update(standardObj);
        }

        public IEnumerable<Standard> getAllStandards()
        {
            return _standardRepository.GetAll();
        }

        public Standard GetStandardByID(int id)
        {
            return _standardRepository.GetById(id);
        }

        public IEnumerable<Student> getAllStudents()
        {
           return _studentRepository.GetAll();
        }

        public Student GetStudentByID(int id)
        {
           return _studentRepository.GetById(id);
        }

        public void addStudent(Student studentObj)
        {
           _studentRepository.Insert(studentObj);
        }

        public void UpdateStudent(Student studentObj)
        {
           _studentRepository.Update(studentObj);
        }

        public void RemoveStudent(Student studentObj)
        {
           _studentRepository.Delete(studentObj);
        }

        public Standard GetStandardByName(String name)
        {
           return _standardRepository.GetSingle(d => d.StandardName.Equals(name), d => d.Students);
        }

        public Student GetStudentByName(String name)
        {
           return _studentRepository.GetSingle(d => d.StudentName.Equals(name), d => d.Standard);
        }

        public IEnumerable<Student> GetStudentByStandardID(int id)
        {
            return _studentRepository.SearchFor(d => d.StandardId == id);
        }
    }
}
