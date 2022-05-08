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
    public class DiseaseDTOServiceTranslator : IServiceTranslator<DiseaseDTO, Disease>
    {
        public Disease Add(DiseaseDTO item)
        {
            Disease tempDisease = new Disease()
            {
                Id = item.Id,
                NameDesease = item.Name,
                Description = item.Description
            };

            return tempDisease;
        }

        public IList<DiseaseDTO> GetAll(IList<Disease> items)
        {
            IList<DiseaseDTO> diseaseDTOs = null;
            if (items.Count > 0)
            {
                diseaseDTOs = new List<DiseaseDTO>();
                DiseaseDTO tempDisease = new DiseaseDTO();

                foreach (var item in items)
                {
                    tempDisease.Id = item.Id;
                    tempDisease.Name = item.NameDesease;
                    tempDisease.Description = item.Description;

                    diseaseDTOs.Add(tempDisease);
                }
            }

            return diseaseDTOs;
        }

        public DiseaseDTO GetItem(Disease item)
        {
            DiseaseDTO analysisDTO = new DiseaseDTO()
            {
                Id = item.Id,
                Name = item.NameDesease,
                Description = item.Description
            };

            return analysisDTO;
        }

        public Disease Update(DiseaseDTO item)
        {
            return new Disease()
            {
                Id = item.Id,
                NameDesease = item.Name,
                Description = item.Description
            };
        }
    }
}