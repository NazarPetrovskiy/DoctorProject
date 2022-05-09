using ClientDAL.Context;
using ClientDAL.Model;
using ClientDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDAL.IRepository
{
    public class AnalysesRepository : BaseRepository<Analysis, int>
    {
        private readonly DataLibrary dataLibrary;

        public AnalysesRepository(DataLibrary _dataLibrary) : base(_dataLibrary)
        {
            dataLibrary = _dataLibrary;
        }
    }
}
