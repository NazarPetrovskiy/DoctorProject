using ClientDAL.IRepository;
using ClientBLL.Interfaces;
using ClientBLL.Models;
using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Services
{
    public class AnalysisDTOService : IService<AnalysisDTO>
    {
        private IRepository<Analysis> _repository;
        private AnalysisDTOServiceTranslator _serviceTranslator;

        public AnalysisDTOService()
        {
            _serviceTranslator = new AnalysisDTOServiceTranslator();
        }

        public void Add(AnalysisDTO item)
        {
            if(item != null)
                _repository.Add(_serviceTranslator.Add(item));
        }

        public void Delete(int id)
        {
            if (id >= 0)
                _repository.Delete(id);
        }

        public IList<AnalysisDTO> GetAll()
        {
            return _serviceTranslator.GetAll(_repository.GetAll());
        }

        public AnalysisDTO GetItem(int id)
        {
            return _serviceTranslator.GetItem(_repository.GetItem(id));
        }

        public void Update(AnalysisDTO item)
        {
            if(item != null)
                _repository.Update(_serviceTranslator.Update(item));
        }
    }
}