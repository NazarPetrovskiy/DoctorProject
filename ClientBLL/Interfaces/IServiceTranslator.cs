using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Interfaces
{
    public interface IServiceTranslator<T, T2>
    {
        T2 ItemDTO_ToItem(T item);
        T Item_ToItemDTO(T2 item);
    }
}