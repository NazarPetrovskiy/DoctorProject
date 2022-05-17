using ClientBLL.Interfaces;
using ClientBLL.Models;
using ClientBLL.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.ViewModels
{
    public class BaseViewModel
    {
        private IService<DoctorDTOService> _doctorDTOService;

        //public ObservableCollection<DoctorDTO> doctorDTOs;

        public string Login;
        public string Password;

        public BaseViewModel(IService<DoctorDTOService> doctorService)
        {
            _doctorDTOService = doctorService;
        }


    }
}