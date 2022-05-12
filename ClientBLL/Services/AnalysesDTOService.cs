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
    public class AnalysesDTOService : IService<AnalysisDTO>, IServiceTranslator<AnalysisDTO, Analysis>
    {
        private IRepository<Analysis, int> _repository;

        public AnalysesDTOService()
        {
            
        }

        public void Add(AnalysisDTO item)
        {
            _repository.Add(ItemDTO_ToItem(item));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<AnalysisDTO> GetAll()
        {
            List<AnalysisDTO> analysisDTOs = new List<AnalysisDTO>();
            foreach (var item in _repository.GetAll())
            {
                analysisDTOs.Add(Item_ToItemDTO(item));
            }

            return analysisDTOs;
        }

        public AnalysisDTO GetItem(int id)
        {
            return Item_ToItemDTO(_repository.GetItem(id));
        }
        public void Update(AnalysisDTO item)
        {
            _repository.Update(ItemDTO_ToItem(item));
        }

        public Analysis ItemDTO_ToItem(AnalysisDTO item) => new Analysis()
        {
            Id = item.Id,
            Name = item.Name,
            Value = item.Value
        };

        public AnalysisDTO Item_ToItemDTO(Analysis item) => new AnalysisDTO()
        {
            Id = item.Id,
            Name = item.Name,
            Value = item.Value
        };
    }
}