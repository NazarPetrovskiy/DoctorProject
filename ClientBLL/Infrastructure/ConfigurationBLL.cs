using ClientDAL.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBLL.Infrastructure
{
    static public class ConfigurationBLL
    {
        public static void ConfigurationService(ServiceCollection service)
        {
            //service.AddTransient(typeof(IBookRepository), typeof(BookRepository));
            //service.AddTransient(typeof(IUserRepository<DLL.Models.User>), typeof(UserRepository));
        }
    }
}