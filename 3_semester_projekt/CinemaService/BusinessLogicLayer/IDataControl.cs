using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.BusinessLogicLayer
{
    public interface IDataControl<T>
    {
        T GetById(int id);
        IEnumerable<T> Get();
        int Add(T entityToAdd);
        bool Put(int id, List<T> entitiesToUpdate);
        bool Delete(int id);
    }
}
