using System.Collections.Generic;

namespace ISP.Good
{
    public interface IBaseDalContract<T>
    {
        T Add(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
