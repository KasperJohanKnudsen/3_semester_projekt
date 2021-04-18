using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAccess.ControlLayer
{
    public interface IDataControl<T>
    {
        T Get(int id);
        Task<IEnumerable<T>> Get();
        Task<int> Add(T entityToAdd);
        bool Put(T entityToUpdate);
        bool Delete(int id);
    }
}
