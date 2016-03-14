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
    }//end class
}//wns namespace