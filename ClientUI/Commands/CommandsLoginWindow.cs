using ClientBLL.Interfaces;
using ClientBLL.Services;
using ClientUI.ViewModels;
using ClientUI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUI.Commands
{
    public class CommandsLoginWindow : BaseViewModel
    {
        IService<DoctorDTOService> _doctorService;

        public CommandsLoginWindow(IService<DoctorDTOService> doctorService) : base(doctorService)
        {
            _doctorService = doctorService;
        }

        public BaseCommand ShowWindow
        {
            get
            {
                BaseCommand showWindow_ = null;
                return showWindow_ ??= new BaseCommand(x =>
                {
                    WindowLogin windowLogin = new WindowLogin(this);
                    windowLogin.Show();
                });
            }
        }

        public BaseCommand Check_LogIn
        {
            get
            {
                BaseCommand Check_LogIn_ = null;
                return Check_LogIn_ ??= new BaseCommand(x =>
                {
                    // Logic
                });
            }
        }
    }
}