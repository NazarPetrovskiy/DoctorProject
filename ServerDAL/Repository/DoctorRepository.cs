using ServerDAL.IRepository;
using ServerDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDAL.Repository
{
    public class DoctorRepository : IRepository<Doctor>
    {
        public void Add(Doctor item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Doctor GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Doctor item)
        {
            throw new NotImplementedException();
        }
    }
}
