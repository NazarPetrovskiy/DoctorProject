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
    public class PeopleInfoDTOService :IService<PeopleInfoDTO> ,IServiceTranslator<PeopleInfoDTO, PeopleInfo>
    {
        private IRepository<PeopleInfo> _repository;

        public PeopleInfoDTOService()
        {

        }

        public void Add(PeopleInfoDTO item)
        {
            _repository.Add(ItemDTO_ToItem(item));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<PeopleInfoDTO> GetAll()
        {
            List<PeopleInfoDTO> peopleInfoDTOs = new List<PeopleInfoDTO>();
            foreach (var item in _repository.GetAll())
            {
                peopleInfoDTOs.Add(Item_ToItemDTO(item));
            }

            return peopleInfoDTOs;
        }

        public PeopleInfoDTO GetItem(int id)
        {
            return Item_ToItemDTO(_repository.GetItem(id));
        }

        public void Update(PeopleInfoDTO item)
        {
            _repository.Update(ItemDTO_ToItem(item));
        }

        public PeopleInfoDTO Item_ToItemDTO(PeopleInfo item) => new PeopleInfoDTO()
        {
            Id = item.Id,
            Name = item.Name,
            LastName = item.LastName,
            Age = item.Age
        };

        public PeopleInfo ItemDTO_ToItem(PeopleInfoDTO item) => new PeopleInfo()
        {
            Id = item.Id,
            Name = item.Name,
            LastName = item.LastName,
            Age = item.Age
        };
    }
}