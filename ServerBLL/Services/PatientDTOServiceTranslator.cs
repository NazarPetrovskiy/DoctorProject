using ServerBLL.Interfaces;
using ServerBLL.Models;
using ServerDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Services
{
    public class PatientDTOServiceTranslator : IServiceTranslator<PatientDTO, Patient>
    {
        public Patient Add(PatientDTO patient)
        {
            // Translate Analysis
            IList<Analysis> analyses = new List<Analysis>();
            foreach (var item in patient.Analyses)
            {
                Analysis analysis = new Analysis()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Value = item.Value
                };
                analyses.Add(analysis);
            }

            // Translate Diseases
            IList<Disease> diseases = new List<Disease>();
            foreach (var item in patient.DiseaseDTOs)
            {
                Disease disease = new Disease()
                {
                    Id = item.Id,
                    NameDesease = item.Name,
                    Description = item.Description
                };
                diseases.Add(disease);
            }

            // Translate Patient
            Patient tempPatient = new Patient()
            {
                Id = patient.Id,
                InfoPeople = new PeopleInfo()
                {
                    Id = patient.InfoPeople.Id,
                    Name = patient.InfoPeople.Name,
                    LastName = patient.InfoPeople.LastName,
                    Age = patient.InfoPeople.Age
                },
                Likar = new Doctor()
                {
                    Id = patient.HealingDoctor.Id,
                    InfoPeople = new PeopleInfo()
                    {
                        Id = patient.HealingDoctor.InfoPeople.Id,
                        Name = patient.HealingDoctor.InfoPeople.Name,
                        LastName = patient.HealingDoctor.InfoPeople.LastName,
                        Age = patient.HealingDoctor.InfoPeople.Age
                    }
                },
                Analyses = analyses,
                Diseases = diseases
            };

            return tempPatient;
        }

        public IList<PatientDTO> GetAll(IList<Patient> items)
        {
            IList<PatientDTO> patientDTOs = null;
            if (items.Count > 0)
            {
                patientDTOs = new List<PatientDTO>();

                // Translate Analysis
                IList<AnalysisDTO> analysis = new List<AnalysisDTO>();
                AnalysisDTO analysisItemDTO = new AnalysisDTO();
                foreach (var item in items)
                {
                    foreach (var analysisItem in item.Analyses)
                    {
                        analysisItemDTO.Id = analysisItem.Id;
                        analysisItemDTO.Name = analysisItem.Name;
                        analysisItemDTO.Value = analysisItem.Value;

                        analysis.Add(analysisItemDTO);
                    }
                }

                // Translate Diseases
                IList<DiseaseDTO> diseases = new List<DiseaseDTO>();
                DiseaseDTO diseasesItemDTO = new DiseaseDTO();
                foreach (var item in items)
                {
                    foreach (var diseasesItem in item.Diseases)
                    {
                        diseasesItemDTO.Id = diseasesItem.Id;
                        diseasesItemDTO.Name = diseasesItem.NameDesease;
                        diseasesItemDTO.Description = diseasesItem.Description;

                        diseases.Add(diseasesItemDTO);
                    }
                }

                // Translate Patients
                PatientDTO tempPatient = new PatientDTO();
                foreach (var item in items)
                {
                    tempPatient.Id = item.Id;
                    tempPatient.InfoPeople = new PeopleInfoDTO()
                    {
                        Id = item.InfoPeople.Id,
                        Name = item.InfoPeople.Name,
                        LastName = item.InfoPeople.LastName,
                        Age = item.InfoPeople.Age
                    };
                    tempPatient.HealingDoctor = new DoctorDTO()
                    {
                        Id = item.Likar.Id,
                        InfoPeople = new PeopleInfoDTO()
                        {
                            Id = item.Likar.InfoPeople.Id,
                            Name = item.Likar.InfoPeople.Name,
                            LastName = item.Likar.InfoPeople.LastName,
                            Age = item.Likar.InfoPeople.Age
                        },
                        Specialty = item.Likar.Specialty,
                    };
                    tempPatient.Analyses = analysis;
                    tempPatient.DiseaseDTOs = diseases;

                    patientDTOs.Add(tempPatient);
                }
            }

            return patientDTOs;
        }

        public PatientDTO GetItem(Patient item)
        {
            // Translate Analysis
            IList<AnalysisDTO> analysis = new List<AnalysisDTO>();
            AnalysisDTO analysisItemDTO = new AnalysisDTO();
            foreach (var analysisItem in item.Analyses)
            {
                analysisItemDTO.Id = analysisItem.Id;
                analysisItemDTO.Name = analysisItem.Name;
                analysisItemDTO.Value = analysisItem.Value;

                analysis.Add(analysisItemDTO);
            }

            // Translate Diseases
            IList<DiseaseDTO> diseases = new List<DiseaseDTO>();
            DiseaseDTO diseasesItemDTO = new DiseaseDTO();
            foreach (var diseasesItem in item.Diseases)
            {
                diseasesItemDTO.Id = diseasesItem.Id;
                diseasesItemDTO.Name = diseasesItem.NameDesease;
                diseasesItemDTO.Description = diseasesItem.Description;

                diseases.Add(diseasesItemDTO);
            }

            // Translate Patient
            PatientDTO patientDTO = new PatientDTO()
            {
                Id = item.Id,
                InfoPeople = new PeopleInfoDTO()
                {
                    Id = item.InfoPeople.Id,
                    Name = item.InfoPeople.Name,
                    LastName = item.InfoPeople.LastName,
                    Age = item.InfoPeople.Age
                },
                HealingDoctor = new DoctorDTO()
                {
                    Id = item.Likar.Id,
                    InfoPeople = new PeopleInfoDTO()
                    {
                        Id = item.Likar.InfoPeople.Id,
                        Name = item.Likar.InfoPeople.Name,
                        LastName = item.Likar.InfoPeople.LastName,
                        Age = item.Likar.InfoPeople.Age
                    },
                    Specialty = item.Likar.Specialty
                },
                Analyses = analysis,
                DiseaseDTOs = diseases
            };

            return patientDTO;
        }

        public Patient Update(PatientDTO item)
        {
            // Translate Analysis
            IList<Analysis> analysisArray = new List<Analysis>();
            Analysis analysis = new Analysis();
            foreach (var analysisItem in item.Analyses)
            {
                analysis.Id = analysisItem.Id;
                analysis.Name = analysisItem.Name;
                analysis.Value = analysisItem.Value;

                analysisArray.Add(analysis);
            }

            // Translate Diseases
            IList<Disease> diseasesArray = new List<Disease>();
            Disease diseases = new Disease();
            foreach (var diseasesItem in item.DiseaseDTOs)
            {
                diseases.Id = diseasesItem.Id;
                diseases.NameDesease = diseasesItem.Name;
                diseases.Description = diseasesItem.Description;

                diseasesArray.Add(diseases);
            }

            // Translate Patient
            return new Patient()
            {
                Id = item.Id,
                InfoPeople = new PeopleInfo()
                {
                    Id = item.InfoPeople.Id,
                    Name = item.InfoPeople.Name,
                    LastName = item.InfoPeople.LastName,
                    Age = item.InfoPeople.Age
                },
                Likar = new Doctor()
                {
                    Id = item.HealingDoctor.Id,
                    InfoPeople = new PeopleInfo()
                    {
                        Id = item.HealingDoctor.InfoPeople.Id,
                        Name = item.HealingDoctor.InfoPeople.Name,
                        LastName = item.HealingDoctor.InfoPeople.LastName,
                        Age = item.HealingDoctor.InfoPeople.Age
                    }
                },
                Analyses = analysisArray,
                Diseases = diseasesArray
            };
        }
    }
}