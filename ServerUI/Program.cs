using ServerDAL.Context;
using ServerDAL.IRepository;
using ServerDAL.Model;
using System;

namespace ServerUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AnalysesRepository analysesRepository = new AnalysesRepository();
                //analysesRepository.Add(new Analysis() { Name = "Аналізи для бабушки", Value = "Liku" });
                var list = analysesRepository.GetAll();
                foreach (var item in list)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("All good");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //PeopleInfo peopleInfo = new PeopleInfo();
            ////peopleInfo.Id = 1;
            //peopleInfo.Name = "Petrttgwrtwtrro";
            //peopleInfo.LastName = "Vinicerwetghuk";
            //peopleInfo.Age = 20;

            //try
            //{
            //    DataLibrary dataLibrary = new DataLibrary();
            //    dataLibrary.PeopleInfos.Add(peopleInfo);
            //    dataLibrary.SaveChanges();

            //    Console.WriteLine("Дані записані ");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Помилка: " + ex.Message);
            //}
        }
    }
}
