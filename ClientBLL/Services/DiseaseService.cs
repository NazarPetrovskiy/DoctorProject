using System;
using System.Collections.Generic;
using ClientBLL.Interfaces;
using ClientBLL.Models;

namespace ClientBLL.Services
{
    public class DiseaseService : IService<Disease>, ITranslator<Disease>
    {
        public void Add(Disease item)
        {
            throw new NotImplementedException();
        }

        public Disease BytesToItem(byte[] bytes)
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

        public byte[] ItemToBytes(Disease item)
        {
            throw new NotImplementedException();
        }

        public void Update(Disease item)
        {
            throw new NotImplementedException();
        }
    }
}
