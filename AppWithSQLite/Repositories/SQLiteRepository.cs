using AppWithSQLite.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AppWithSQLite.Repositories
{
    public class SQLiteRepository : IRepository
    {
        private readonly AppDbContext _context;
        
        public SQLiteRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<T> SelectAll<T>() where T : class
        {
            var entities = _context.Set<T>().ToList();
            return entities;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T SelectById<T>(int id) where T : class
        {
            var entity = _context.Set<T>().Find(id);
            return entity;
        }
    }
}
