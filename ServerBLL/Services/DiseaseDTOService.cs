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
    public class DiseaseDTOService : IService<DiseaseDTO>
    {
        private IRepository<Disease> _repository;
        private DiseaseDTOServiceTranslator _serviceTranslator;

        public DiseaseDTOService()
        {
            _serviceTranslator = new DiseaseDTOServiceTranslator();
        }

        public void Add(DiseaseDTO item)
        {
            if (item != null)
                _repository.Add(_serviceTranslator.Add(item));
        }

        public void Delete(int id)
        {
            if (id >= 0)
                _repository.Delete(id);
        }

        public IList<DiseaseDTO> GetAll()
        {
            return _serviceTranslator.GetAll(_repository.GetAll());
        }

        public DiseaseDTO GetItem(int id)
        {
            return _serviceTranslator.GetItem(_repository.GetItem(id));
        }

        public void Update(DiseaseDTO item)
        {
            if (item != null)
                _repository.Update(_serviceTranslator.Update(item));
        }
    }
}