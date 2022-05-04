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
    public class PatientDTOService : IService<PatientDTO>
    {
        ObservableCollection<PatientDTO> _patientDTOs;

        public PatientDTOService()
        {
            _patientDTOs = new ObservableCollection<PatientDTO>();
        }

        public void Add(PatientDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<PatientDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public PatientDTO GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PatientDTO item)
        {
            throw new NotImplementedException();
        }
    }
}