using Autofac;
using ClientBLL.Infrastructure;
using ClientBLL.Interfaces;
using ClientBLL.Models;
using ClientBLL.Services;
using ClientDAL.IRepository;
using ClientDAL.Model;
using ClientUI.ViewModels;
using ClientUI.Windows;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ClientUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceCollection _serviceCollection;
        private ContainerBuilder _containerBuilder;
        private IContainer _container;

        public App()
        {
            _serviceCollection = new ServiceCollection();
            _containerBuilder = new ContainerBuilder();
            ConfigurationService();
        }

        private void ConfigurationService()
        {
            _containerBuilder.RegisterType<BaseViewModel>();

            //_containerBuilder.RegisterType<IRepository<Doctor, int>>();
            //_containerBuilder.RegisterType<IRepositoryUser>();
            //_containerBuilder.RegisterType<IRepository<PeopleInfo, int>>();

            _containerBuilder.RegisterType<PeopleInfoDTOService>().As<IService<PeopleInfoDTO>>();
            _containerBuilder.RegisterType<AnalysesDTOService>().As<IService<AnalysisDTO>>();
            _containerBuilder.RegisterType<DiseaseDTOService>().As<IService<DiseaseDTO>>();
            _containerBuilder.RegisterType<PatientDTOService>().As<IService<PatientDTO>>();
            _containerBuilder.RegisterType<DoctorDTOService>().As<IService<DoctorDTO>>();

            _containerBuilder.RegisterType<WindowLogin>();

            _container = _containerBuilder.Build();
            ConfigurationBLL.ConfigurationService(_serviceCollection);
        }

        private void OnStartUp(object sender, StartupEventArgs startupEventArgs)
        {
            WindowLogin startWindow = _container.Resolve<WindowLogin>();
            startWindow.Show();
        }
    }
}