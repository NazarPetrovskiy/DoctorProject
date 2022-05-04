using ServerDAL.IRepository;
using ServerDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDAL.Repository
{
    public class PatientRepository : IRepository<Patient>
    {
        public void Add(Patient item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Patient> GetAll()
        {
            throw new NotImplementedException();
        }

        public Patient GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Patient item)
        {
            throw new NotImplementedException();
        }
    }
}
