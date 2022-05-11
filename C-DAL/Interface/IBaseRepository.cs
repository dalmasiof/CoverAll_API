using System.Collections.Generic;

namespace CoverAll_API.C_DAL.Interface
{
    public interface IBaseRepository <T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        ICollection<T> GetList();
        bool SaveChanges();
    }
}