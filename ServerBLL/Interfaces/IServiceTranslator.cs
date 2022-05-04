using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Interfaces
{
    public interface IServiceTranslator<T, T2>
    {
        IList<T2> GetAll();
        T2 GetItem(int id);
        T2 Add(T item);
        T2 Update(T item);
    }
}