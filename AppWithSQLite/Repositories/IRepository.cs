using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithSQLite.Repositories
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        List<T> SelectAll<T>() where T : class;

        T SelectById<T>(int id) where T : class;
    }
}
