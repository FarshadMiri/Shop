using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ApplicationDbContext _context { get; }
        public Repository(ApplicationDbContext context)
        {
            _context = context;

        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public List<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Set<T>().AddOrUpdate(entity);
            _context.SaveChanges();
        }

    }
}
