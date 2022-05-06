using System;
using System.Collections.Generic;
using ClientBLL.Interfaces;
using ClientBLL.Models;

namespace ClientBLL.Services
{
    public class PatientService : IService<Patient>, ITranslator<Patient>
    {
        public void Add(Patient item)
        {
            throw new NotImplementedException();
        }

        public Patient BytesToItem(byte[] bytes)
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

        public byte[] ItemToBytes(Patient item)
        {
            throw new NotImplementedException();
        }

        public void Update(Patient item)
        {
            throw new NotImplementedException();
        }
    }
}
