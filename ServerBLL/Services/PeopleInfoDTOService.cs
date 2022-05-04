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
    public class PeopleInfoDTOService : IService<PeopleInfoDTO>
    {
        private ObservableCollection<PeopleInfoDTO> _doctorDTOs;

        public PeopleInfoDTOService()
        {
            _doctorDTOs = new ObservableCollection<PeopleInfoDTO>();
        }

        public void Add(PeopleInfoDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<PeopleInfoDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public PeopleInfoDTO GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PeopleInfoDTO item)
        {
            throw new NotImplementedException();
        }
    }
}