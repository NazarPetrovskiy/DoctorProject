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
        private IRepository<Patient, int> _repository;

        public PatientDTOService()
        {
            
        }

        public void Add(PatientDTO item)
        {
            _repository.Add(ItemDTO_ToItem(item));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<PatientDTO> GetAll()
        {
            List<PatientDTO> peopleInfoDTOs = new List<PatientDTO>();
            foreach (var item in _repository.GetAll())
            {
                peopleInfoDTOs.Add(Item_ToItemDTO(item));
            }

            return peopleInfoDTOs;
        }

        public PatientDTO GetItem(int id)
        {
            return Item_ToItemDTO(_repository.GetItem(id));
        }

        public void Update(PatientDTO item)
        {
            _repository.Update(ItemDTO_ToItem(item));
        }

        public Patient ItemDTO_ToItem(PatientDTO item)
        {
            IQueryable<Analysis> analysis = new List<Analysis>().AsQueryable();
            foreach (var value in item.Analyses)
            {
                analysis.Append(new AnalysesDTOService().ItemDTO_ToItem(value));
            }

            IQueryable<Disease> diseases = new List<Disease>().AsQueryable();
            foreach (var value in item.Diseases)
            {
                diseases.Append(new DiseaseDTOService().ItemDTO_ToItem(value));
            }

            return new Patient()
            {
                Id = item.Id,
                InfoPeople = new PeopleInfoDTOService().ItemDTO_ToItem(item.InfoPeople),
                Likar = new DoctorDTOService().ItemDTO_ToItem(item.HealingDoctor),
                Analyses = analysis.ToList(),
                Diseases = diseases.ToList()
            };
        }

        public PatientDTO Item_ToItemDTO(Patient item)
        {
            IQueryable<AnalysisDTO> analysis = new List<AnalysisDTO>().AsQueryable();
            foreach (var value in item.Analyses)
            {
                analysis.Append(new AnalysesDTOService().Item_ToItemDTO(value));
            }

            IQueryable<DiseaseDTO> diseases = new List<DiseaseDTO>().AsQueryable();
            foreach (var value in item.Diseases)
            {
                diseases.Append(new DiseaseDTOService().Item_ToItemDTO(value));
            }

            return new PatientDTO()
            {
                Id = item.Id,
                InfoPeople = new PeopleInfoDTOService().Item_ToItemDTO(item.InfoPeople),
                HealingDoctor = new DoctorDTOService().Item_ToItemDTO(item.Likar),
                Analyses = analysis.ToList(),
                Diseases = diseases.ToList()
            };
        }
    }
}