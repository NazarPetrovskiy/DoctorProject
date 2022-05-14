using ClientBLL.Interfaces;
using ClientBLL.Models;
using ClientDAL.IRepository;
using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Services
{
    public class DiseaseDTOService : IService<DiseaseDTO>, IServiceTranslator<DiseaseDTO, Disease>
    {
        private IRepository<Disease, int> _repository;

        public DiseaseDTOService(IRepository<Disease, int> repository)
        {
            _repository = repository;
        }

        public void Add(DiseaseDTO item)
        {
            _repository.Add(ItemDTO_ToItem(item));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<DiseaseDTO> GetAll()
        {
            List<DiseaseDTO> diseaseDTOs = new List<DiseaseDTO>();
            foreach (var item in _repository.GetAll())
            {
                diseaseDTOs.Add(Item_ToItemDTO(item));
            }

            return diseaseDTOs;
        }

        public DiseaseDTO GetItem(int id)
        {
            return Item_ToItemDTO(_repository.GetItem(id));
        }

        public void Update(DiseaseDTO item)
        {
            _repository.Update(ItemDTO_ToItem(item));
        }

        public Disease ItemDTO_ToItem(DiseaseDTO item) => new Disease()
        {
            Id = item.Id,
            Description = item.Description,
            NameDesease = item.Name
        };

        public DiseaseDTO Item_ToItemDTO(Disease item) => new DiseaseDTO()
        {
            Id = item.Id,
            Description = item.Description,
            Name = item.NameDesease
        };
    }
}