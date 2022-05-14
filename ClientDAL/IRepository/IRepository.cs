using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDAL.IRepository
{
    public interface IRepository<TEntity, TIdType>
    {
        public bool Add(TEntity entity);
        public bool Update(TEntity entity);
        public TEntity GetItem(int Id);
        public IQueryable<TEntity> GetAll();
        public bool Delete(TIdType id);

    }
}
