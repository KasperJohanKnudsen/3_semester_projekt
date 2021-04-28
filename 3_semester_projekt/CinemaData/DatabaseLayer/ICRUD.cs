using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public interface ICRUD<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        int Create(T entity);
        bool Update(int id, List<T> updateEntities);
        bool Delete(int id);

    }
}
