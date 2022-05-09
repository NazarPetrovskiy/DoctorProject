
using ClientDAL.Context;
using ClientDAL.IRepository;
using ClientDAL.Repository;
using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLibrary context = new DataLibrary();
            try
            {
                PeopleInfoRepository analysesRepository = new PeopleInfoRepository(context);
                analysesRepository.Add(new ClientDAL.Model.PeopleInfo() { Name = "dcwc", LastName = "Detthnthnorogi", Age = 22});

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
