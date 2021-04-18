using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class TheaterDatabaseAccess : ICRUD<Theater>
    {
        readonly string _connectionString;
        public TheaterDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CinemaConnection");
        }

        public TheaterDatabaseAccess(string inConnectionString)
        {
            _connectionString = inConnectionString;
        }
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

        public Theater GetById(int findId)
        {
            Theater foundTheater = null;
            //
            string queryString = "select TheaterID, Seats, TheaterName, NoOfRows, SeatsPerRow from Theater where TheaterID = @TheaterID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Put the Id parameter into the command so that we know which room to read
                SqlParameter idParam = new SqlParameter("@TheaterID", findId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                foundTheater = new Theater();

                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        foundTheater = GetFromReader(productReader);

                    }
                }
            }
            return foundTheater;
        }

        private Theater GetFromReader(SqlDataReader productReader)
        {
            Theater foundTheater;

            int tempId;
            int tempSeats;
            string tempTheaterName;
            int tempNoOfRows;
            int tempSeatsPerRow;


            tempId = productReader.GetInt32(productReader.GetOrdinal("TheaterID"));
            tempSeats = productReader.GetInt32(productReader.GetOrdinal("Seats"));
            tempTheaterName = productReader.GetString(productReader.GetOrdinal("TheaterName"));
            tempNoOfRows = productReader.GetInt32(productReader.GetOrdinal("NoOfRows"));
            tempSeatsPerRow = productReader.GetInt32(productReader.GetOrdinal("SeatsPerRow"));


            //Build the booking with the values from the database
            foundTheater = new Theater(tempId, tempSeats, tempTheaterName, tempNoOfRows, tempSeatsPerRow);
            return foundTheater;
        }

        public bool Update(Theater entity)
        {
            throw new NotImplementedException();
        }
    }
}
