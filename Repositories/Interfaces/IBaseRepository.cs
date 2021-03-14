using System;
using System.Collections.Generic;
using System.Text;

namespace Series.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        List<T> List();
        T ReturnById(int pId);

        void Insert(T pEntity);

        void Delete(int pId);

        void Update(int pId, T pEntity);

        int NextId();
    }
}
