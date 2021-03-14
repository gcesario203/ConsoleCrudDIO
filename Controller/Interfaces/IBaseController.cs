using System;
using System.Collections.Generic;
using System.Text;

namespace Series.Controller.Interfaces
{
    public interface IBaseController<T>
    {
        void List();
        void Insert();
        void Update();
        void Delete();
        void ReturnById();
        void Clean();
    }
}
