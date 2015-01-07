using System.Collections.Generic;

namespace ISP.Bad
{
    public interface IDalContract<T>
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
