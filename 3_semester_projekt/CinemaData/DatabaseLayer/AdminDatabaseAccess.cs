using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class AdminDatabaseAccess : ICRUD<Admin>
    {
        public int Create(Admin entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Admin GetById(int id)
        {
            throw new NotImplementedException();
        }
        public bool Update(int id, List<Admin> updateEntities)
        {
            throw new NotImplementedException();
        }
    }
}
