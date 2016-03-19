/**************************************
 * 
 * George Rhee and Imanuel Kurniawan
 * CECS 475 - Lab Assignment #5
 * Repository.cs
 * 
 * ************************************/

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

      //Constructor
      public Repository(DbContext datacontext)
      {
         DbSet = datacontext.Set<T>();
         context = datacontext;
      }//end constructor Repository

      //Insert generic object into database
      public void Insert(T entity)
      {
         DbSet.Add(entity);
         context.SaveChanges();
      }//end method Insert

      //Delete generic object from database
      public void Delete(T entity)
      {
         DbSet.Remove(entity);
         context.SaveChanges();
      }//end method Delete

      //Update generic object from database
      public void Update(T entity)
      {
         context.Entry(entity).State = EntityState.Modified;
      }//end method Update

      //Get generic object
      public T GetById(int id)
      {
         return DbSet.Find(id);
      }//end method GetById

      public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
      {
         return DbSet.Where(predicate);
      }//end method SearchFor

      //Get all generic object
      public IEnumerable<T> GetAll()
      {
         return DbSet;
      }//end method GetAll

      public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
      {
         T item = null;
         IQueryable<T> dbQuery = null;
         foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
            dbQuery = DbSet.Include<T, object>(navigationProperty);

         item = dbQuery
             .AsNoTracking()
             .FirstOrDefault(where);
         return item;

      }//end method GetSingle
   }//end class Repository
}//end namespace CECS_475___Lab_Assignment_5