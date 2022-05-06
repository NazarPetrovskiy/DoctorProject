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
    public class PatientDTOService : IService<PatientDTO>
    {
        private IRepository<Patient> _repository;
        private PatientDTOServiceTranslator _serviceTranslator;

        public PatientDTOService()
        {
            _serviceTranslator = new PatientDTOServiceTranslator();
        }

        public void Add(PatientDTO item)
        {
            if (item != null)
                _repository.Add(_serviceTranslator.Add(item));
        }

        public void Delete(int id)
        {
            if (id >= 0)
                _repository.Delete(id);
        }

        public IList<PatientDTO> GetAll()
        {
            return _serviceTranslator.GetAll(_repository.GetAll());
        }

        public PatientDTO GetItem(int id)
        {
            return _serviceTranslator.GetItem(_repository.GetItem(id));
        }

        public void Update(PatientDTO item)
        {
            if (item != null)
                _repository.Update(_serviceTranslator.Update(item));
        }
    }
}