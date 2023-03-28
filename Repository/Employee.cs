using RepositoryPatternInMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPatternInMVC.Repository
{
    public class Employee<T> : IEmployee<T> where T : class
    {
        private StudentContext _context;
        private IDbSet<T> dbEntity;

        public Employee()
        {
            _context = new StudentContext();
            dbEntity = _context.Set<T>();
        }

        public void Delete(int employeeid)
        {
            T model = dbEntity.Find(employeeid);
            dbEntity.Remove(model);
        }

        public IEnumerable<T> GetAll()
        {
            return dbEntity.ToList();
        }

        public T GetById(int employeeid)
        {
            return dbEntity.Find(employeeid);
        }

        public void Insert(T obj)
        {
            dbEntity.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            dbEntity.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}