using System.Collections.Generic;

namespace CoverAll_API.B_Service
{
    public interface IBaseService<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        ICollection<T> GetList();
        bool SaveChanges();
    }
}