using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Interfaces
{
    public interface ITranslator<T>
    {

        byte[] ItemToBytes(T item);
        T BytesToItem(byte[] bytes);
       
    }
}
