using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class TheaterDatabaseAccess : ICRUD<Theater>
    {
        public int Create(Theater entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Theater> GetAll()
        {
            throw new NotImplementedException();
        }

        public Theater GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Theater GetFromReader(SqlDataReader productReader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Theater entity)
        {
            throw new NotImplementedException();
        }
    }
}
