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
    public class DiseaseRepository : IRepository<Disease>
    {
        private DataLibrary dataLibrary;
        public DiseaseRepository()
        {
            dataLibrary = new DataLibrary();
        }
        public void Add(Disease item)
        {
           if(item != null)
            {
                dataLibrary.Diseases.Add(item);
                dataLibrary.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var temp = dataLibrary.Diseases.Find(id);

            if(temp != null)
            {
                dataLibrary.Diseases.Remove(temp);
                dataLibrary.SaveChanges();
            }
        }

        public IList<Disease> GetAll()
        {
            return dataLibrary.Diseases.ToList();
        }

        public Disease GetItem(int id)
        {
            var temp =  dataLibrary.Diseases.Find(id);

            if(temp != null)
            {
                return temp;
            }
            throw new NotImplementedException();
        }

        public void Update(Disease item)
        {
            if (item != null)
            {
                dataLibrary.Diseases.Update(item);
            }
        }
    }
}
