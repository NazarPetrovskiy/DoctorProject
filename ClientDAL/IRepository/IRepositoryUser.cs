using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDAL.IRepository
{
    public interface IRepositoryUser : IRepository<Doctor, int>
    {
        public bool IsLogin(string l, string p);
    }
}
