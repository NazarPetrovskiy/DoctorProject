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
    public class PeopleInfoRepository : BaseRepository<PeopleInfo, int>
    {
        private readonly DataLibrary dataLibrary;

        public PeopleInfoRepository(DataLibrary _dataLibrary) : base(_dataLibrary)
        {
            dataLibrary = _dataLibrary;
        }
    }
}
