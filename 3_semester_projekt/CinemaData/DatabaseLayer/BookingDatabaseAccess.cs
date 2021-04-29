using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class BookingDatabaseAccess : ICRUD<Booking>
    {
        readonly string _connectionString;
        SeatBookingDatabaseAccess _seatBookingDatabaseAccess;

        // Using iconfiguration to get hold of a connectionstring
        public BookingDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CinemaConnection");
            _seatBookingDatabaseAccess = new SeatBookingDatabaseAccess(_connectionString);
        }

        // For booking data test project
        public BookingDatabaseAccess(string inConnectionString)
        {
            _connectionString = inConnectionString;
        }

        public int Create(Booking aBooking, int showingId, List<SeatBooking> newSeatBookings)
        {
            // I think we use -1 because then we are sure that it is not from the database if it returns that
            int insertedId = -1;


            string insertString = "insert into Booking(UserID, ShowingId, Price, SeatsBooked, SeatBookingID) OUTPUT INSERTED.BookingID values (@UserID, @ShowingID, @Price, @SeatsBooked, @SeatBookingId)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                // Opens the connection
                con.Open();
                //Create the command with a sql script

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
                    {
                        try
                        {
                            CreateCommand.Transaction = transaction;
                            // Prepare SQL
                            // Prepares a parameters inside the database to receive a property from the class
                            SqlParameter userIdParam = new SqlParameter("@UserID", aBooking.UserId);
                            SqlParameter showingIdParam = new SqlParameter("@ShowingID", aBooking.ShowingId);
                            SqlParameter priceParam = new SqlParameter("@Price", aBooking.Price);
                            SqlParameter seatsBookedParam = new SqlParameter("@SeatsBooked", aBooking.SeatsBooked);
                            SqlParameter seatBookingIdParam = new SqlParameter("@SeatBookingID", aBooking.SeatBookingId);


                            //Adds the above parameter to a Command
                            CreateCommand.Parameters.Add(userIdParam);
                            CreateCommand.Parameters.Add(showingIdParam);
                            CreateCommand.Parameters.Add(priceParam);
                            CreateCommand.Parameters.Add(seatsBookedParam);
                            CreateCommand.Parameters.Add(seatBookingIdParam);

                            // Execute the command, save and read generated key (ID)
                            insertedId = (int)CreateCommand.ExecuteScalar();

                            _seatBookingDatabaseAccess.Update(showingId, newSeatBookings);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            transaction.Rollback();
                        }
                    }
                    // Returns the new id, if it's -1 something is wrong
                    return insertedId;

                }

            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Booking> GetAll()
        {
            // To get all users we need to create a liste to put them into
            List<Booking> foundBookings;
            // Create a new object user that we build from the database
            Booking readBooking;


            string queryString = "select BookingID, UserID, ShowingID, Price, SeatsBooked, SeatBookingID from Booking";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                // Initialize the list
                foundBookings = new List<Booking>();

                while (productReader.Read())
                {
                    readBooking = GetFromReader(productReader);
                    foundBookings.Add(readBooking);
                }
            }
            return foundBookings;
        }

        public Booking GetById(int findId)
        {
            Booking foundBooking = null;
            //
            string queryString = "select BookingID, UserID, ShowingID, Price, SeatsBooked, SeatBookingID from Booking where BookingID = @BookingID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Put the Id parameter into the command so that we know which room to read
                SqlParameter idParam = new SqlParameter("@BookingID", findId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                foundBooking = new Booking();

                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        foundBooking = GetFromReader(productReader);

                    }
                }
            }
            return foundBooking;
        }

        private Booking GetFromReader(SqlDataReader productReader)
        {
            Booking foundBooking;

            int tempId;
            int tempUserId;
            int tempShowingId;
            decimal tempPrice;
            string tempSeatsBooked;
            int tempSeatBookingId;


            tempId = productReader.GetInt32(productReader.GetOrdinal("BookingID"));
            tempUserId = productReader.GetInt32(productReader.GetOrdinal("UserID"));
            tempShowingId = productReader.GetInt32(productReader.GetOrdinal("ShowingID"));
            tempPrice = productReader.GetDecimal(productReader.GetOrdinal("Price"));
            tempSeatsBooked = productReader.GetString(productReader.GetOrdinal("SeatsBooked"));
            tempSeatBookingId = productReader.GetInt32(productReader.GetOrdinal("SeatBookingID"));

            //Build the booking with the values from the database
            foundBooking = new Booking(tempId, tempUserId, tempShowingId, tempPrice, tempSeatsBooked, tempSeatBookingId);
            return foundBooking;
        }


        public bool Update(int id, List<Booking> updateEntities)
        {
            throw new NotImplementedException();
        }
    }

}
