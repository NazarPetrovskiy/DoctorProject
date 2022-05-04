using ServerBLL.Interfaces;
using ServerBLL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Services
{
    public class AnalysisDTOService : IService<AnalysisDTO>
    {
        private ObservableCollection<AnalysisDTO> _analysisDTOs;

        public AnalysisDTOService()
        {
            _analysisDTOs = new ObservableCollection<AnalysisDTO>();
        }

        public void Add(AnalysisDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<AnalysisDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public AnalysisDTO GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AnalysisDTO item)
        {
            throw new NotImplementedException();
        }
    }
}