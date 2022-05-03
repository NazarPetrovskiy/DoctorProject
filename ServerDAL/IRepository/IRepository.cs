using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDAL.IRepository
{
    public interface IRepository<T>
    {
        public void Add(T obj);
        public void Find(int id);
        public void Update(T obj);
        public void Delete(T obj);
    }
}
