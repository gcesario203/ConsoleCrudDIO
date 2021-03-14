using System;
using System.Collections.Generic;
using System.Linq;
using Series.Repositories.Interfaces;
using Series.Entities;

namespace Series.Repositories
{
    public class SerieRepository : IBaseRepository<Serie>
    {
        private List<Serie> lList = new List<Serie>();
        public void Delete(int pId)
        {
            lList[pId].handleExcludeSerie();
        }

        public void Insert(Serie pEntity)
        {
            lList.Add(pEntity);
        }

        public List<Serie> List()
        {
            return lList;
        }

        public int NextId()
        {
            return lList.Count;
        }

        public Serie ReturnById(int pId)
        {
            return lList[pId];
        }

        public void Update(int pId, Serie pEntity)
        {
            lList[pId] = pEntity;
        }
    }
}
