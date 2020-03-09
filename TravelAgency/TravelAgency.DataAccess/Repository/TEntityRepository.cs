using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.DataAccess.Repository
{
    public class TEntityRepository<TEntity>:IRepository<TEntity> where TEntity:BaseEntity
    {
        private readonly TravelAgencyContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public TEntityRepository(TravelAgencyContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();

        }
        public void Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(int? skip = null, int? take = null)
        {
           return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}