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
    public class DoctorDTOService : IService<DoctorDTO>
    {
        private ObservableCollection<DoctorDTO> _doctorDTOs;

        public DoctorDTOService()
        {
            _doctorDTOs = new ObservableCollection<DoctorDTO>();
        }

        public void Add(DoctorDTO item)
        {

            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DoctorDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public DoctorDTO GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DoctorDTO item)
        {
            throw new NotImplementedException();
        }

        public bool IsLogin(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}