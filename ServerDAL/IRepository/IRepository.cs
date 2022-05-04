using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDAL.IRepository
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
        T GetItem(int id);
        void Add(T item);
        void Delete(int id);
        void Update(T item);
    }
}
