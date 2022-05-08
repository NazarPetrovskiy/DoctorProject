using ClientDAL.Context;
using ClientDAL.IRepository;
using ClientDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDAL.Repository
{
    public class PeopleInfoRepository : IRepository<PeopleInfo>
    {
        private DataLibrary dataLibrary;
        public PeopleInfoRepository()
        {
            dataLibrary = new DataLibrary();
        }
        public void Add(PeopleInfo item)
        {
            if(item != null)
            {
                dataLibrary.PeopleInfos.Add(item);
                dataLibrary.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var temp = dataLibrary.PeopleInfos.Find(id);

            if(temp != null)
            {
                dataLibrary.PeopleInfos.Remove(temp);
                dataLibrary.SaveChanges();
            }
        }

        public IList<PeopleInfo> GetAll()
        {
            return dataLibrary.PeopleInfos.ToList();
        }

        public PeopleInfo GetItem(int id)
        {
            var temp = dataLibrary.PeopleInfos.Find(id);

            if(temp != null)
            {
                return temp;
            }
            throw new NotImplementedException();
        }

        public void Update(PeopleInfo item)
        {
            if(item != null)
            {
                dataLibrary.PeopleInfos.Update(item);
                dataLibrary.SaveChanges();
            }
        }
    }
}
