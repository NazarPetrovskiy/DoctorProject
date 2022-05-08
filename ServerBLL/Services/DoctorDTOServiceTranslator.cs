using ClientBLL.Interfaces;
using ClientBLL.Models;
using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Services
{
    public class DoctorDTOServiceTranslator : IServiceTranslator<DoctorDTO, Doctor>
    {
        public Doctor Add(DoctorDTO item)
        {
            Doctor tempDoctor = new Doctor()
            {
                Id = item.Id,
                InfoPeople = new PeopleInfo()
                {
                    Id = item.InfoPeople.Id,
                    Name = item.InfoPeople.Name,
                    LastName = item.InfoPeople.LastName,
                    Age = item.InfoPeople.Age
                }
            };

            return tempDoctor;
        }

        public IList<DoctorDTO> GetAll(IList<Doctor> items)
        {
            IList<DoctorDTO> doctorDTOs = null;
            if (items.Count > 0)
            {
                doctorDTOs = new List<DoctorDTO>();
                DoctorDTO tempDoctor = new DoctorDTO();

                foreach (var item in items)
                {
                    tempDoctor.Id = item.Id;
                    tempDoctor.Specialty = item.Specialty;
                    tempDoctor.InfoPeople = new PeopleInfoDTO()
                    {
                        Id = item.InfoPeople.Id,
                        Name = item.InfoPeople.Name,
                        LastName = item.InfoPeople.LastName,
                        Age = item.InfoPeople.Age
                    };

                    doctorDTOs.Add(tempDoctor);
                }
            }

            return doctorDTOs;
        }

        public DoctorDTO GetItem(Doctor item)
        {
            DoctorDTO doctorDTO = new DoctorDTO()
            {
                Id = item.Id,
                Specialty = item.Specialty,
                InfoPeople = new PeopleInfoDTO()
                {
                    Id = item.InfoPeople.Id,
                    Name = item.InfoPeople.Name,
                    LastName = item.InfoPeople.LastName,
                    Age = item.InfoPeople.Age
                }
            };

            return doctorDTO;
        }

        public Doctor Update(DoctorDTO item)
        {
            return new Doctor()
            {
                Id = item.Id,
                Specialty = item.Specialty,
                InfoPeople = new PeopleInfo()
                {
                    Id = item.InfoPeople.Id,
                    Name = item.InfoPeople.Name,
                    LastName = item.InfoPeople.LastName,
                    Age = item.InfoPeople.Age
                }
            };
        }
    }
}