using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Linq;

namespace Core_Project.Repository.Concreate
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
       protected readonly System.Data.Entity.DbContext context;
        public Repository(DbContext _context)
        {

            context = _context;
        }
        public Tentity SingleOrDefault(Expression<Func<Tentity, bool>> predicate)
        {
            return context.Set<Tentity>().SingleOrDefault(predicate);
        }
        public void Add(Tentity entity)
        {
            context.Set<Tentity>().Add(entity);
        }

        public void AddRange(IEnumerable<Tentity> entities)
        {
            context.Set<Tentity>().AddRange(entities);
        }

        public IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> predicate)
        {
            return context.Set<Tentity>().Where(predicate);
        }
        public Tentity Get(int Id)
        {
            return context.Set<Tentity>().Find(Id);
        }

        public IEnumerable<Tentity> GetAll()
        {
            return context.Set<Tentity>().ToList();
        }

        public void Remove(Tentity entity)
        {
            context.Set<Tentity>().Remove(entity);
        }

        public void Removerange(IEnumerable<Tentity> entities)
        {
            context.Set<Tentity>().RemoveRange(entities);
        }
    }
}
