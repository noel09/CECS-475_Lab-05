using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CECS_475___Lab_Assignment_5
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext context;
        protected DbSet<T> DbSet;

        public Repository(DbContext datacontext)
        {
            DbSet = datacontext.Set<T>();
            context = datacontext;
        }
        
        public void Insert(T entity)
        {
            DbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        
        public T GetById(int id)
        {
            return DbSet.Find(id);
        }
        
        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }
        
        public IEnumerable<T> GetAll()
        {
            return DbSet;
        }

        public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        //This method will find the related records by passing two argument
        //First argument: lambda expression to search a record such as d => d.StandardName.Equals(standardName) to search am record by standard name
        //Second argument: navigation property that leads to the related records such as d => d.Students
        //The method returns the related records that met the condition in the first argument.
        //An example of the method GetStandardByName(string standardName)
        //public Standard GetStandardByName(string standardName)
        //{
        //return _standardRepository.GetSingle(d => d.StandardName.Equals(standardName), d => d.Students);
        //} 
        {
            T item = null;
            IQueryable<T> dbQuery = null;
            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                dbQuery = DbSet.Include<T, object>(navigationProperty);

            item = dbQuery
                .AsNoTracking()
                .FirstOrDefault(where);
            return item;

        }


    }//end class
}//wns namespace