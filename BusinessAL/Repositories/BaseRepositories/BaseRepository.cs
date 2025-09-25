using BusinessAL.DbContext;
using DataAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAL.Repositories.BaseRepositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public RepositoryContext _context { get; }
        public DatabaseFacade db { get; }

        //private readonly RepositoryContext _context;

        public BaseRepository(RepositoryContext _context)
        {
            this._context = _context;
            db = this._context.Database;
        }

        //public IQueryable<T> ExecuteSqlQueryRaw(string sql, params object[] parameters)
        //{
        //    return this._context.Database.SqlQueryRaw<T>(sql, parameters);
        //}

        public T Delete(T entity)
        {
            var result = _context.Set<T>().Remove(entity) as T;
            _context.SaveChanges();
            return result;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Insert(T entity)
        {
            var result = _context.Set<T>().Add(entity) as T;
            _context.SaveChanges();
            return result;
        }

        public void InsertRange(T entity)
        {
            _context.Set<T>().AddRange(entity);
            _context.SaveChanges();
        }

        public T Update(T entity)
        {
            var result = _context.Set<T>().Update(entity) as T;
            _context.SaveChanges();
            return result;
        }

        public IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }


        #region Abstract

        //public abstract T GetById(int id);

        #endregion
    }
}
