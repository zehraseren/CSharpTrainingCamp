using System.Collections.Generic;

namespace CSTC301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(int id);
        T GetById(int id);
        List<T> GetList();
    }
}
