using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.BusinessLogicLayer
{
    public interface IDataControl<T>
    {
        T Get(int id);
        IEnumerable<T> Get();
        int Add(T entityToAdd);
        bool Put(T entityToUpdate);
        bool Delete(int id);
    }
}
