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

        private readonly IConfiguration _configuration;

        // Using iconfiguration to get hold of a connectionstring
        public ShowingDatabaseAccess(IConfiguration configuration)
        {
            _configuration = configuration;
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

        public Showing GetShowingById(int showingId)
        {
            Showing foundShowing = null;
            //
            string queryString = "select title, room, startTime, showingId from Showing_View where showingId = @ShowingID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Put the Id parameter into the command so that we know which room to read
                SqlParameter idParam = new SqlParameter("@ShowingID", showingId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                foundShowing = new Showing();

                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        foundShowing = GetShowingFromReader(productReader);

                    }
                }
            }
            return foundShowing;
        }

        public bool Update(Showing entity)
        {
            throw new NotImplementedException();
        }

        public List<SeatBooking> GetSeatBookingByShowingId(int showingId)
        {
            SeatBooking readSeatBooking;

            List<SeatBooking> foundSeatBookings = null;
            //SeatBookingDatabaseAccess _sbAccess = new SeatBookingDatabaseAccess(_configuration);

            string queryString = "select showingId, RowNo, SeatNo, IsReserved from SeatBooking_View where ShowingID = @ShowingID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                SqlParameter idParam = new SqlParameter("@ShowingID", showingId);
                readCommand.Parameters.Add(idParam);
                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                // Initialize the list
                foundSeatBookings = new List<SeatBooking>();

                while (productReader.Read())
                {
                    readSeatBooking = GetViewFromReader(productReader);
                    foundSeatBookings.Add(readSeatBooking);
                }
            }
            return foundSeatBookings;
        }

        private Showing GetShowingFromReader(SqlDataReader productReader)
        {
            Showing foundShowing;

            string tempTitle;
            string tempRoom;
            DateTime tempShowTime;
            int tempId;

            tempTitle = productReader.GetString(productReader.GetOrdinal("title"));
            tempRoom = productReader.GetString(productReader.GetOrdinal("room"));
            tempShowTime = productReader.GetDateTime(productReader.GetOrdinal("startTime"));
            tempId = productReader.GetInt32(productReader.GetOrdinal("showingId"));


            //Build the booking with the values from the database
            foundShowing = new Showing(tempId, tempTitle, tempRoom, tempShowTime);
            return foundShowing;


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

        public SeatBooking GetViewFromReader(SqlDataReader productReader)
        {

            //TODO: Replace GetFromReader in seatbookingaccess with this method
            SeatBooking foundSeatBooking;

            int tempId;
            int tempRowNo;
            int tempSeatNo;
            bool tempIsReserved;


            tempId = productReader.GetInt32(productReader.GetOrdinal("showingId"));
            tempRowNo = productReader.GetInt32(productReader.GetOrdinal("RowNo"));
            tempSeatNo = productReader.GetInt32(productReader.GetOrdinal("SeatNo"));
            tempIsReserved = productReader.GetBoolean(productReader.GetOrdinal("IsReserved"));


            //Build the booking with the values from the database
            foundSeatBooking = new SeatBooking(tempId, tempIsReserved, tempRowNo, tempSeatNo);
            return foundSeatBooking;
        }
    }
}
