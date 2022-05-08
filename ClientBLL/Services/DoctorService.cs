using ClientBLL.Interfaces;
using ClientBLL.Models;
using System;
using System.Collections.Generic;

namespace ClientBLL.Services
{
    public class DoctorService : IService<Doctor>, ITranslator<Doctor>
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

        public bool IsLogin(string login, string password)
        {


            //Query query = new Query()
            //{
            //    Type = TypeCommand.Null,
            //    Status = StatusQuery.LogIn,
            //    CurrentModel = CurrentModel.Doctor,
                
            //};

            return true;
        }

        public byte[] ItemToBytes(Doctor item)
        {
            throw new NotImplementedException();
        }

        public Doctor BytesToItem(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }
}
