using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CECS_475___Lab_Assignment_5
{
    public interface IStandardRepository : IRepository<Standard>
    {

    }

    public interface IStudentRepository : IRepository<Student>
    {

    }

    public class StandardRepository : Repository<Standard>, IStandardRepository
    {
        public StandardRepository() : base(new SchoolDBEntities())
        {

        }

        
    }

    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository()
            : base(new SchoolDBEntities())
        {

        }
    }
}
