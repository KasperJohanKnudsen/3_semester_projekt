using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class BookingDatabaseAccess
    {
        readonly string _connectionString;
        SeatBookingDatabaseAccess _sbAccess;

        // Using iconfiguration to get hold of a connectionstring
        public BookingDatabaseAccess(IConfiguration configuration)
        {
            _sbAccess = new SeatBookingDatabaseAccess(configuration);
            _connectionString = configuration.GetConnectionString("CinemaConnection");
        }

        // For booking data test project
        public BookingDatabaseAccess(string inConnectionString)
        {
            _sbAccess = new SeatBookingDatabaseAccess(inConnectionString);
            _connectionString = inConnectionString;
        }

        public int Create(Booking aBooking, int showId, List<SeatBooking> newReservations)
        {
            // I think we use -1 because then we are sure that it is not from the database if it returns that
            int insertedId = -1;


            string insertString = "insert into Booking(PhoneNumber, ShowingId, Price, SeatsBooked, SeatBookingID) OUTPUT INSERTED.BookingID values (@PhoneNumber, @ShowingID, @Price, @SeatsBooked, @SeatBookingId)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            //Create the command with a sql script
            using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
            {

                // Prepare SQL
                // Prepares a parameters inside the database to receive a property from the class
                SqlParameter PhoneNumberParam = new SqlParameter("@PhoneNumber", aBooking.PhoneNumber);
                SqlParameter showingIdParam = new SqlParameter("@ShowingID", aBooking.ShowingId);
                SqlParameter priceParam = new SqlParameter("@Price", aBooking.Price);
                SqlParameter seatsBookedParam = new SqlParameter("@SeatsBooked", aBooking.SeatsBooked);

                //aBooking.SeatsBooked.Substring(0, 2);
                
                SqlParameter seatBookingIdParam = new SqlParameter("@SeatBookingID", aBooking.SeatBookingId);


                //Adds the above parameter to a Command
                CreateCommand.Parameters.Add(PhoneNumberParam);
                CreateCommand.Parameters.Add(showingIdParam);
                CreateCommand.Parameters.Add(priceParam);
                CreateCommand.Parameters.Add(seatsBookedParam);
                CreateCommand.Parameters.Add(seatBookingIdParam);

                bool wentOk = false;
                wentOk =_sbAccess.Update(showId, newReservations);

                // Opens the connection
                con.Open();
                // Execute the command, save and read generated key (ID)
                insertedId = (int)CreateCommand.ExecuteScalar();
            }
            // Returns the new id, if it's -1 something is wrong
            return insertedId;
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


            string queryString = "select BookingID, PhoneNumber, ShowingID, Price, SeatsBooked, SeatBookingID from Booking";
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
            string queryString = "select BookingID, PhoneNumber, ShowingID, Price, SeatsBooked, SeatBookingID from Booking where BookingID = @BookingID";
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
            int tempPhoneNumber;
            int tempShowingId;
            decimal tempPrice;
            string tempSeatsBooked;
            int tempSeatBookingId;


            tempId = productReader.GetInt32(productReader.GetOrdinal("BookingID"));
            tempPhoneNumber = productReader.GetInt32(productReader.GetOrdinal("PhoneNumber"));
            tempShowingId = productReader.GetInt32(productReader.GetOrdinal("ShowingID"));
            tempPrice = productReader.GetDecimal(productReader.GetOrdinal("Price"));
            tempSeatsBooked = productReader.GetString(productReader.GetOrdinal("SeatsBooked"));
            tempSeatBookingId = productReader.GetInt32(productReader.GetOrdinal("SeatBookingID"));

            //Build the booking with the values from the database
            foundBooking = new Booking(tempId, tempPhoneNumber, tempShowingId, tempPrice, tempSeatsBooked, tempSeatBookingId);
            return foundBooking;
        }


        public bool Update(int id, List<Booking> updateEntities)
        {
            throw new NotImplementedException();
        }
    }

}
