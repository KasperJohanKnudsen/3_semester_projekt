using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class BookingDatabaseAccess : IBookingAccess
    {
        readonly string _connectionString;

        // Using iconfiguration to get hold of a connectionstring
        public BookingDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("BookingConnection");
        }

        // For booking data test project
        public BookingDatabaseAccess(string inConnectionString)
        {
            _connectionString = inConnectionString;
        }

        // To Create a booking we NEED a userId AND a roomId, these cannot be null
        // AND the room that we are booking needs to be updated with a userId and a Occupied set to true
        // Though this is probably gonna be coordinated in the controller
        // MAYBE we do not need to get the values from the room and user, when we create, because when we create we just enter which user and which room using their ID
        public int CreateBooking(Booking aBooking)
        {
            // I think we use -1 because then we are sure that it is not from the database if it returns that
            int insertedId = -1;


            string insertString = "insert into Booking(userId, roomId, name) OUTPUT INSERTED.ID values (@userId, @roomId, @name)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            //Create the command with a sql script
            using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
            {

                // Prepare SQL
                // Prepares a parameters inside the database to receive a property from the class
                SqlParameter userIdParam = new SqlParameter("@userId", aBooking.UserId);
                SqlParameter roomIdParam = new SqlParameter("@roomId", aBooking.RoomId);
                SqlParameter nameParam = new SqlParameter("@name", aBooking.Name);


                //Adds the above parameter to a Command
                CreateCommand.Parameters.Add(userIdParam);
                CreateCommand.Parameters.Add(roomIdParam);
                CreateCommand.Parameters.Add(nameParam);


                // Opens the connection
                con.Open();
                // Execute the command, save and read generated key (ID)
                insertedId = (int)CreateCommand.ExecuteScalar();
            }
            // Returns the new id, if it's -1 something is wrong
            return insertedId;
        }

        public bool DeleteBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetBookingAll()
        {
            // To get all users we need to create a liste to put them into
            List<Booking> foundBookings;
            // Create a new object user that we build from the database
            Booking readBooking;


            string queryString = "select ID, userId, roomId, name from Booking";
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
                    readBooking = GetBookingFromReader(productReader);
                    foundBookings.Add(readBooking);
                }
            }
            return foundBookings;
        }

        public Booking GetBookingById(int findId)
        {
            Booking foundBooking = null;
            //
            string queryString = "select ID, userId, roomId, name from Booking where ID = @ID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Put the Id parameter into the command so that we know which room to read
                SqlParameter idParam = new SqlParameter("@ID", findId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                foundBooking = new Booking();

                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        foundBooking = GetBookingFromReader(productReader);

                    }
                }
            }
            return foundBooking;
        }

        public bool UpdateBooking(Booking bookingToUpdate)
        {
            throw new NotImplementedException();
        }

        private Booking GetBookingFromReader(SqlDataReader productReader)
        {
            Booking foundBooking;
            int tempId;
            int tempUserId;
            int tempRoomId;
            string tempName;

            tempId = productReader.GetInt32(productReader.GetOrdinal("ID"));
            tempUserId = productReader.GetInt32(productReader.GetOrdinal("userId"));
            tempRoomId = productReader.GetInt32(productReader.GetOrdinal("roomId"));
            tempName = productReader.GetString(productReader.GetOrdinal("name"));

            //Build the booking with the values from the database
            foundBooking = new Booking(tempId, tempUserId, tempRoomId, tempName);
            return foundBooking;
        }

    }

}
