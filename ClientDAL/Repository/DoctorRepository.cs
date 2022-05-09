using ClientDAL.Context;
using ClientDAL.IRepository;
using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDAL.Repository
{
    public class DoctorRepository : BaseRepository<Doctor, int>, IRepositoryUser
    {
        private readonly DataLibrary dataLibrary;

        public DoctorRepository(DataLibrary _dataLibrary) : base(_dataLibrary)
        {
            dataLibrary = _dataLibrary;
        }

        public bool IsLogin(string l, string p)
        {
            return true;
            //return _context.UserInfos.Count(x => x.Email == email && x.Password == password) > 0;
        }
    }
}
