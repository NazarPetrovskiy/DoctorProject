using ServerDAL.Context;
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
        private DataLibrary dataLibrary;
        public PatientRepository()
        {
            dataLibrary = new DataLibrary();
        }
        public void Add(Patient item)
        {
            if(item != null)
            {
                dataLibrary.Patients.Add(item);
                dataLibrary.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var temp = dataLibrary.Patients.Find(id);

            if(temp != null)
            {
                dataLibrary.Patients.Remove(temp);
                dataLibrary.SaveChanges();
            }
        }

        public IList<Patient> GetAll()
        {
            return dataLibrary.Patients.ToList();
        }

        public Patient GetItem(int id)
        {
            var temp = dataLibrary.Patients.Find(id);

            if(temp != null)
            {
                return temp;
            }
            throw new NotImplementedException();
        }

        public void Update(Patient item)
        {
            if(item != null)
            {
                dataLibrary.Patients.Update(item);
                dataLibrary.SaveChanges();
            }
        }
    }
}
