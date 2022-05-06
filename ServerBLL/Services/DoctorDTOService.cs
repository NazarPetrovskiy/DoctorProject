using ServerBLL.Interfaces;
using ServerBLL.Models;
using ServerDAL.IRepository;
using ServerDAL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Services
{
    public class DoctorDTOService : IService<DoctorDTO>
    {
        private IRepository<Doctor> _repository;
        private DoctorDTOServiceTranslator _serviceTranslator;

        public DoctorDTOService()
        {
            _serviceTranslator = new DoctorDTOServiceTranslator();
        }

        public void Add(DoctorDTO item)
        {
            if (item != null)
                _repository.Add(_serviceTranslator.Add(item));
        }

        public void Delete(int id)
        {
            if (id >= 0)
                _repository.Delete(id);
        }

        public IList<DoctorDTO> GetAll()
        {
            return _serviceTranslator.GetAll(_repository.GetAll());
        }

        public DoctorDTO GetItem(int id)
        {
            return _serviceTranslator.GetItem(_repository.GetItem(id));
        }

        public void Update(DoctorDTO item)
        {
            if (item != null)
                _repository.Update(_serviceTranslator.Update(item));
        }

        public bool IsLogin(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}