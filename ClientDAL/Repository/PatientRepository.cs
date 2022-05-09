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
    public class PatientRepository : BaseRepository<Patient, int>
    {
        private readonly DataLibrary dataLibrary;

        public PatientRepository(DataLibrary _dataLibrary) : base(_dataLibrary)
        {
            dataLibrary = _dataLibrary;
        }
    }
}
