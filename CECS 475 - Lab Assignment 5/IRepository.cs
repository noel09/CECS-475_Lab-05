﻿/**************************************
 * 
 * George Rhee and Imanuel Kurniawan
 * CECS 475 - Lab Assignment #5
 * IRepository.cs
 * 
 * ************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CECS_475___Lab_Assignment_5
{
   public interface IRepository<T>
   {
      void Insert(T entity);
      void Delete(T entity);
      void Update(T entity);
      T GetById(int id);
      IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
      IEnumerable<T> GetAll();
      T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
   }//end interface IRepository
}//end namespace CECS_475___Lab_Assignment_5