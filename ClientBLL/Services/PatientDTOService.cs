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
    public class PatientDTOService : IService<PatientDTO>, IServiceTranslator<PatientDTO, Patient>
    {
        private IRepository<Patient, int> _repositoryPatient;
        private IRepository<Analysis, int> _repositoryAnalyses;
        private IRepository<Disease, int> _repositoryDisease;
        private IRepository<Doctor, int> _repositoryDoctor;
        private IRepositoryUser _repositoryUserDoctor;
        private IRepository<PeopleInfo, int> _repositoryPeopleInfo;

        public PatientDTOService(IRepository<Patient, int> repositoryPatient,
                                 IRepository<Analysis, int> repositoryAnalyses,
                                 IRepository<Disease, int> repositoryDisease,
                                 IRepository<Doctor, int> repositoryDoctor,
                                 IRepositoryUser repositoryUserDoctor,
                                 IRepository<PeopleInfo, int> repositoryPeopleInfo)
        {
            _repositoryPatient = repositoryPatient;
            _repositoryAnalyses = repositoryAnalyses;
            _repositoryDisease = repositoryDisease;
            _repositoryDoctor = repositoryDoctor;
            _repositoryUserDoctor = repositoryUserDoctor;
            _repositoryPeopleInfo = repositoryPeopleInfo;
        }

        public void Add(PatientDTO item)
        {
            _repositoryPatient.Add(ItemDTO_ToItem(item));
        }

        public void Delete(int id)
        {
            _repositoryPatient.Delete(id);
        }

        public IList<PatientDTO> GetAll()
        {
            List<PatientDTO> peopleInfoDTOs = new List<PatientDTO>();
            foreach (var item in _repositoryPatient.GetAll())
            {
                peopleInfoDTOs.Add(Item_ToItemDTO(item));
            }

            return peopleInfoDTOs;
        }

        public PatientDTO GetItem(int id)
        {
            return Item_ToItemDTO(_repositoryPatient.GetItem(id));
        }

        public void Update(PatientDTO item)
        {
            _repositoryPatient.Update(ItemDTO_ToItem(item));
        }

        public Patient ItemDTO_ToItem(PatientDTO item)
        {
            IQueryable<Analysis> analysis = new List<Analysis>().AsQueryable();
            foreach (var value in item.Analyses)
            {
                analysis.Append(new AnalysesDTOService(_repositoryAnalyses).ItemDTO_ToItem(value));
            }

            IQueryable<Disease> diseases = new List<Disease>().AsQueryable();
            foreach (var value in item.Diseases)
            {
                diseases.Append(new DiseaseDTOService(_repositoryDisease).ItemDTO_ToItem(value));
            }

            return new Patient()
            {
                Id = item.Id,
                InfoPeople = new PeopleInfoDTOService(_repositoryPeopleInfo).ItemDTO_ToItem(item.InfoPeople),
                Likar = new DoctorDTOService(_repositoryDoctor, _repositoryUserDoctor, _repositoryPeopleInfo).ItemDTO_ToItem(item.HealingDoctor),
                Analyses = analysis.ToList(),
                Diseases = diseases.ToList()
            };
        }

        public PatientDTO Item_ToItemDTO(Patient item)
        {
            IQueryable<AnalysisDTO> analysis = new List<AnalysisDTO>().AsQueryable();
            foreach (var value in item.Analyses)
            {
                analysis.Append(new AnalysesDTOService(_repositoryAnalyses).Item_ToItemDTO(value));
            }

            IQueryable<DiseaseDTO> diseases = new List<DiseaseDTO>().AsQueryable();
            foreach (var value in item.Diseases)
            {
                diseases.Append(new DiseaseDTOService(_repositoryDisease).Item_ToItemDTO(value));
            }

            return new PatientDTO()
            {
                Id = item.Id,
                InfoPeople = new PeopleInfoDTOService(_repositoryPeopleInfo).Item_ToItemDTO(item.InfoPeople),
                HealingDoctor = new DoctorDTOService(_repositoryDoctor, _repositoryUserDoctor, _repositoryPeopleInfo).Item_ToItemDTO(item.Likar),
                Analyses = analysis.ToList(),
                Diseases = diseases.ToList()
            };
        }
    }
}