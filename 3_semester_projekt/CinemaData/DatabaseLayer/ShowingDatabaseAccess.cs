using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class ShowingDatabaseAccess : ICRUD<Showing>
    {
        readonly string _connectionString;

        // Using iconfiguration to get hold of a connectionstring
        public ShowingDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CinemaConnection");
        }

        public ShowingDatabaseAccess(string inConnectionString)
        {
            _connectionString = inConnectionString;
        }
        public int Create(Showing entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Showing> GetAll()
        {

            List<Showing> foundShowings;
            // Create a new object user that we build from the database
            Showing readShowing;


            string queryString = "select ShowingID, MovieID, TheaterID, StartTime, Date, SeatBookingID from Showing";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                // Initialize the list
                foundShowings = new List<Showing>();

                while (productReader.Read())
                {
                    readShowing = GetFromReader(productReader);
                    foundShowings.Add(readShowing);
                }
            }
            return foundShowings;
        }

        public Showing GetById(int findId)
        {
            Showing foundShowing = null;
            //
            string queryString = "select ShowingID, MovieID, TheaterID, StartTime, Date, SeatBookingID from Showing where ShowingID = @ShowingID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Put the Id parameter into the command so that we know which room to read
                SqlParameter idParam = new SqlParameter("@ShowingID", findId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                foundShowing = new Showing();

                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        foundShowing = GetFromReader(productReader);

                    }
                }
            }
            return foundShowing;
        }

        public bool Update(Showing entity)
        {
            throw new NotImplementedException();
        }

        private Showing GetFromReader(SqlDataReader productReader)
        {

            Showing foundShowing;

            int tempId;
            int tempMovieId;
            int tempTheaterId;
            DateTime tempStartTime;
            DateTime tempDate;
            int tempSeatBookingId;


            tempId = productReader.GetInt32(productReader.GetOrdinal("ShowingID"));
            tempMovieId = productReader.GetInt32(productReader.GetOrdinal("MovieID"));
            tempTheaterId = productReader.GetInt32(productReader.GetOrdinal("TheaterID"));
            tempStartTime = productReader.GetDateTime(productReader.GetOrdinal("StartTime"));
            tempDate = productReader.GetDateTime(productReader.GetOrdinal("Date"));
            tempSeatBookingId = productReader.GetInt32(productReader.GetOrdinal("SeatBookingID"));


            //Build the booking with the values from the database
            foundShowing = new Showing(tempId, tempMovieId, tempTheaterId, tempStartTime, tempDate, tempSeatBookingId);
            return foundShowing;


        }
    }
}
