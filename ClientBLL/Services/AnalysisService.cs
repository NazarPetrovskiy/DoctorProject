using System;
using System.Collections.Generic;
using ClientBLL.Interfaces;
using ClientBLL.Models;

namespace ClientBLL.Services
{
    public class AnalysisService : IService<Analysis>, ITranslator<Analysis>
    {
        public void Add(Analysis item)
        {
            throw new NotImplementedException();
        }

        public Analysis BytesToItem(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Analysis> GetAll()
        {
            throw new NotImplementedException();
        }

        public Analysis GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public byte[] ItemToBytes(Analysis item)
        {
            throw new NotImplementedException();
        }

        public void Update(Analysis item)
        {
            throw new NotImplementedException();
        }
    }
}
