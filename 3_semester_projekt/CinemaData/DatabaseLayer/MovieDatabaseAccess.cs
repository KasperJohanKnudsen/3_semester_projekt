using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class MovieDatabaseAccess : ICRUD<Movie>
    {
        public int Create(Movie entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetFromReader(SqlDataReader productReader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
