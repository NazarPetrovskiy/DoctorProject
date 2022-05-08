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
    public class DoctorRepository : IRepository<Doctor>
    {
        private DataLibrary dataLibrary;
        public DoctorRepository()
        {
            dataLibrary = new DataLibrary();
        }
        public void Add(Doctor item)
        {
           if(item != null)
            {
                dataLibrary.Doctors.Add(item);
                dataLibrary.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var temp = dataLibrary.Doctors.Find(id);
            
            if(temp != null)
            {
                dataLibrary.Doctors.Remove(temp);
                dataLibrary.SaveChanges();
            }
        }

        public IList<Doctor> GetAll()
        {
            return dataLibrary.Doctors.ToList();
        }

        public Doctor GetItem(int id)
        {
            var temp = dataLibrary.Doctors.Find(id);

            if(temp != null)
            {
                return temp;
            }
            throw new NotImplementedException();
        }

        public void Update(Doctor item)
        {
            if (item != null)
            {
                dataLibrary.Doctors.Update(item);
                dataLibrary.SaveChanges();
            }
        }
    }
}
