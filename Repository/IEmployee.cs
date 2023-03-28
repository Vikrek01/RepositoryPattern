using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternInMVC.Repository
{
    internal interface IEmployee<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int employeeid);

        void Insert(T obj);
        void Update(T obj);
        void Delete(int employeeid);

        void Save();
    }
}
