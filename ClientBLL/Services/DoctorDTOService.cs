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
    public class DoctorDTOService : IService<DoctorDTO>, IServiceTranslator<DoctorDTO, Doctor>
    {
        private IRepository<Doctor> _repository;

        public DoctorDTOService()
        {
            
        }

        public void Add(DoctorDTO item)
        {
            _repository.Add(ItemDTO_ToItem(item));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<DoctorDTO> GetAll()
        {
            List<DoctorDTO> doctorDTOs = new List<DoctorDTO>();
            foreach (var item in _repository.GetAll())
            {
                doctorDTOs.Add(Item_ToItemDTO(item));
            }

            return doctorDTOs;
        }

        public DoctorDTO GetItem(int id)
        {
            return Item_ToItemDTO(_repository.GetItem(id));
        }

        public void Update(DoctorDTO item)
        {
            _repository.Update(ItemDTO_ToItem(item));
        }

        public Doctor ItemDTO_ToItem(DoctorDTO item) => new Doctor()
        {
            Id = item.Id,
            InfoPeople = new PeopleInfoDTOService().ItemDTO_ToItem(item.InfoPeople),
            Specialty = item.Specialty
        };

        public DoctorDTO Item_ToItemDTO(Doctor item) => new DoctorDTO()
        {
            Id = item.Id,
            InfoPeople = new PeopleInfoDTOService().Item_ToItemDTO(item.InfoPeople),
            Specialty = item.Specialty
        };
    }
}