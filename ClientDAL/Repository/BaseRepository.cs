using ClientDAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientDAL.IRepository;
using ClientDAL.Model;

namespace ClientDAL.Repository
{
    public class BaseRepository<TEntity, TIdType> :
        IRepository<TEntity, TIdType> where TEntity : class, IEntity<TIdType>
    {
        private readonly DataLibrary _context;
        public BaseRepository(DataLibrary context)
        {
            _context = context;
        }
        public bool Add(TEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(TIdType id)
        {
            try
            {
                var item = _context.Set<TEntity>().Find(id);
                if (item != null)
                {
                    _context.Set<TEntity>().Remove(item);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _context.Update<TEntity>(entity);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
