using ServerDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Interfaces
{
    public interface IServiceTranslator<T, T2>
    {
        IList<T> GetAll(IList<T2> items);
        T GetItem(T2 item);
        T2 Add(T item);
        T2 Update(T item);
    }
}