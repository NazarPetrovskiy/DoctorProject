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
        private IRepository<Doctor, int> _repositoryDoctor;
        private IRepositoryUser _repositoryUserDoctor;

        private IRepository<PeopleInfo, int> _repositoryPeopleInfo;

        public DoctorDTOService(IRepository<Doctor, int> repositoryDoctor,
                                IRepositoryUser repositoryUserDoctor,
                                IRepository<PeopleInfo, int> repositoryPeopleInfo)
        {
            _repositoryDoctor = repositoryDoctor;
            _repositoryUserDoctor = repositoryUserDoctor;
            _repositoryPeopleInfo = repositoryPeopleInfo;
        }

        public void Add(DoctorDTO item)
        {
            _repositoryDoctor.Add(ItemDTO_ToItem(item));
        }

        public void Delete(int id)
        {
            _repositoryDoctor.Delete(id);
        }

        public IList<DoctorDTO> GetAll()
        {
            List<DoctorDTO> doctorDTOs = new List<DoctorDTO>();
            foreach (var item in _repositoryDoctor.GetAll())
            {
                doctorDTOs.Add(Item_ToItemDTO(item));
            }

            return doctorDTOs;
        }

        public DoctorDTO GetItem(int id)
        {
            return Item_ToItemDTO(_repositoryDoctor.GetItem(id));
        }

        public void Update(DoctorDTO item)
        {
            _repositoryDoctor.Update(ItemDTO_ToItem(item));
        }

        public Doctor ItemDTO_ToItem(DoctorDTO item) => new Doctor()
        {
            Id = item.Id,
            InfoPeople = new PeopleInfoDTOService(_repositoryPeopleInfo).ItemDTO_ToItem(item.InfoPeople),
            Specialty = item.Specialty
        };

        public DoctorDTO Item_ToItemDTO(Doctor item) => new DoctorDTO()
        {
            Id = item.Id,
            InfoPeople = new PeopleInfoDTOService(_repositoryPeopleInfo).Item_ToItemDTO(item.InfoPeople),
            Specialty = item.Specialty
        };

        public bool IsLogin(string login, string password)
        {
            return _repositoryUserDoctor.IsLogin(login, password);
        }
    }
}