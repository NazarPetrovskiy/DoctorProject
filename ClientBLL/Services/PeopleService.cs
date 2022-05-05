using ClientBLL.Interfaces;
using ClientBLL.Models;
using System;
using System.Collections.Generic;

namespace ClientBLL.Services
{
    public class PeopleService : IService<People>, ITranslator<People>
    {
        public void Add(People item)
        {
            
        }

        public People BytesToItem(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<People> GetAll()
        {
            throw new NotImplementedException();
        }

        public People GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public byte[] ItemToBytes(People item)
        {
            throw new NotImplementedException();
        }

        public void Update(People item)
        {
            throw new NotImplementedException();
        }
    }
}
