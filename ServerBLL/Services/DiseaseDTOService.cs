using ServerBLL.Interfaces;
using ServerBLL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBLL.Services
{
    public class DiseaseDTOService : IService<DiseaseDTO>
    {
        private ObservableCollection<DiseaseDTO> _diseaseDTOs;

        public DiseaseDTOService()
        {
            _diseaseDTOs = new ObservableCollection<DiseaseDTO>();
        }

        public void Add(DiseaseDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DiseaseDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public DiseaseDTO GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DiseaseDTO item)
        {
            throw new NotImplementedException();
        }
    }
}