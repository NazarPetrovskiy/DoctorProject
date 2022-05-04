using ServerDAL.IRepository;
using ServerDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDAL.Repository
{
    public class DiseaseRepository : IRepository<Disease>
    {
        public void Add(Disease item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Disease> GetAll()
        {
            throw new NotImplementedException();
        }

        public Disease GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Disease item)
        {
            throw new NotImplementedException();
        }
    }
}
