using ClientDAL.Context;
using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDAL.IRepository
{
    public class AnalysesRepository : IRepository<Analysis>
    {
        private DataLibrary dataLibrary;
        public AnalysesRepository()
        {
            dataLibrary = new DataLibrary();
        }
        public void Add(Analysis item)
        {
            if(item != null)
            {
                dataLibrary.Analyses.Add(item);
                dataLibrary.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var temp = dataLibrary.Analyses.Find(id);

            if(temp != null)
            {
                dataLibrary.Analyses.Remove(temp);
                dataLibrary.SaveChanges();
            }
        }

        public IList<Analysis> GetAll()
        {
            return dataLibrary.Analyses.ToList();
        }

        public Analysis GetItem(int id)
        {
            var temp = dataLibrary.Analyses.Find(id);

            if(temp!= null)
            {
                return temp;
            }
            throw new NotImplementedException();
        }

        public void Update(Analysis item)
        {
            if(item != null)
            {
                dataLibrary.Analyses.Update(item);
                dataLibrary.SaveChanges();
            }
        }
    }
}
