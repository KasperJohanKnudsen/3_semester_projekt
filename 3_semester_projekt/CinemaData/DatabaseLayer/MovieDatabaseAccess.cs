using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class MovieDatabaseAccess : ICRUD<Movie>
    {
        readonly string _connectionString;
        public MovieDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CinemaConnection");
        }

        public MovieDatabaseAccess(string inConnectionString)
        {
            _connectionString = inConnectionString;
        }
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

        public Movie GetById(int findId)
        {
            Movie foundMovie = null;
            //
            string queryString = "select MovieID, Title, Duration from Movie where MovieID = @MovieID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Put the Id parameter into the command so that we know which room to read
                SqlParameter idParam = new SqlParameter("@MovieID", findId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                foundMovie = new Movie();

                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        foundMovie = GetFromReader(productReader);

                    }
                }
            }
            return foundMovie;
        }

        private Movie GetFromReader(SqlDataReader productReader)
        {
            Movie foundMovie;

            int tempId;
            string tempTitle;
            string tempDuration;


            tempId = productReader.GetInt32(productReader.GetOrdinal("MovieID"));
            tempTitle = productReader.GetString(productReader.GetOrdinal("Title"));
            tempDuration = productReader.GetString(productReader.GetOrdinal("Duration"));


            //Build the booking with the values from the database
            foundMovie = new Movie(tempId, tempTitle, tempDuration);
            return foundMovie;
        }

        public bool Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
