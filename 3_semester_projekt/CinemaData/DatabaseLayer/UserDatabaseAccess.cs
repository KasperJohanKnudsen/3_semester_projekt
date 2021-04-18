using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class UserDatabaseAccess : ICRUD<User>
    {

        readonly string _connectionString;

        // Using iconfiguration to get hold of a connectionstring
        public UserDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CinemaConnection");
        }

        public UserDatabaseAccess(string inConnectionString)
        {
            _connectionString = inConnectionString;
        }

        public int Create(User aUser)
        {
            int insertedId = -1;


            string insertString = "insert into Booking(UserID, ShowingId, Price, SeatsBooked, SeatBookingID) OUTPUT INSERTED.BookingID values (@UserID, @ShowingID, @Price, @SeatsBooked, @SeatBookingId)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            //Create the command with a sql script
            using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
            {

                // Prepare SQL
                // Prepares a parameters inside the database to receive a property from the class
                SqlParameter phoneNumberParam = new SqlParameter("@PhoneNumber", aUser.PhoneNumber);


                //Adds the above parameter to a Command
                CreateCommand.Parameters.Add(phoneNumberParam);


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

        public IEnumerable<User> GetAll()
        {
            // To get all users we need to create a liste to put them into
            List<User> foundUsers;
            // Create a new object user that we build from the database
            User readUser;


            string queryString = "select UserID, PhoneNumber from Users";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                // Initialize the list
                foundUsers = new List<User>();

                while (productReader.Read())
                {
                    readUser = GetFromReader(productReader);
                    foundUsers.Add(readUser);
                }
            }
            return foundUsers;
        }

        public User GetById(int findId)
        {
            User foundUser = null;
            //
            string queryString = "select UserID, PhoneNumber from Users where UserID = @UserID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Put the Id parameter into the command so that we know which room to read
                SqlParameter idParam = new SqlParameter("@UserID", findId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                foundUser = new User();

                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        foundUser = GetFromReader(productReader);

                    }
                }
            }
            return foundUser;
        }

        private User GetFromReader(SqlDataReader productReader)
        {
            User foundUser;

            int tempId;
            int tempPhoneNumber;


            tempId = productReader.GetInt32(productReader.GetOrdinal("UserID"));
            tempPhoneNumber = productReader.GetInt32(productReader.GetOrdinal("PhoneNumber"));


            //Build the booking with the values from the database
            foundUser = new User(tempId, tempPhoneNumber);
            return foundUser;
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
 
    }
}
