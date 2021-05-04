using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class SeatBookingDatabaseAccess : ICRUD<SeatBooking>
    {
        readonly string _connectionString;

        // Using iconfiguration to get hold of a connectionstring
        public SeatBookingDatabaseAccess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CinemaConnection");
        }

        // For booking data test project
        public SeatBookingDatabaseAccess(string inConnectionString)
        {
            _connectionString = inConnectionString;
        }
        public int Create(SeatBooking aSeatBooking)
        {
            int insertedId = -1;


            string insertString = "insert into SeatBooking(IsReserved, RowNo, SeatNo, ShowingID, PhoneNumber) OUTPUT INSERTED.SeatBookingID values (@IsReserved, @RowNo, @SeatNo, @ShowingID, @PhoneNumber)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            //Create the command with a sql script
            using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
            {

                // Prepare SQL
                // Prepares a parameters inside the database to receive a property from the class
                SqlParameter isReservedParam = new SqlParameter("@IsReserved", aSeatBooking.IsReserved);
                SqlParameter rowNoParam = new SqlParameter("@RowNo", aSeatBooking.RowNo);
                SqlParameter seatNoParam = new SqlParameter("@SeatNo", aSeatBooking.SeatNo);
                SqlParameter showingIdParam = new SqlParameter("@ShowingID", aSeatBooking.ShowingId);
                SqlParameter phoneNumberParam = new SqlParameter("@PhoneNumber", aSeatBooking.PhoneNumber);


                //Adds the above parameter to a Command
                CreateCommand.Parameters.Add(isReservedParam);
                CreateCommand.Parameters.Add(rowNoParam);
                CreateCommand.Parameters.Add(seatNoParam);
                CreateCommand.Parameters.Add(showingIdParam);
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

        public IEnumerable<SeatBooking> GetAll()
        {
            List<SeatBooking> foundSeatBookings;
            // Create a new object user that we build from the database
            SeatBooking readSeatBooking;


            string queryString = "select SeatBookingID, IsReserved, RowNo, SeatNo, ShowingID, PhoneNumber from SeatBooking";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                // Initialize the list
                foundSeatBookings = new List<SeatBooking>();

                while (productReader.Read())
                {
                    readSeatBooking = GetFromReader(productReader);
                    foundSeatBookings.Add(readSeatBooking);
                }
            }
            return foundSeatBookings;
        }

        public SeatBooking GetById(int findId)
        {
            SeatBooking foundSeatBooking = null;
            //
            string queryString = "select SeatBookingID, IsReserved, RowNo, SeatNo, ShowingID, PhoneNumber from SeatBooking where SeatBookingID = @SeatBookingID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                // Put the Id parameter into the command so that we know which room to read
                SqlParameter idParam = new SqlParameter("@SeatBookingID", findId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // SQLDatareader reads data from the database
                SqlDataReader productReader = readCommand.ExecuteReader();
                foundSeatBooking = new SeatBooking();

                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        foundSeatBooking = GetFromReader(productReader);

                    }
                }
            }
            return foundSeatBooking;
        }

        public SeatBooking GetFromReader(SqlDataReader productReader)
        {
            SeatBooking foundSeatBooking;

            int tempId;
            bool tempIsReserved;
            int tempRowNo;
            int tempSeatNo;
            int tempShowId;
            int tempPhoneNumber = productReader["PhoneNumber"] as int? ?? -1;


            tempId = productReader.GetInt32(productReader.GetOrdinal("SeatBookingID"));
            tempIsReserved = productReader.GetBoolean(productReader.GetOrdinal("IsReserved"));
            tempRowNo = productReader.GetInt32(productReader.GetOrdinal("RowNo"));
            tempSeatNo = productReader.GetInt32(productReader.GetOrdinal("SeatNo"));
            tempShowId = productReader.GetInt32(productReader.GetOrdinal("ShowingID"));



            //Build the booking with the values from the database
            foundSeatBooking = new SeatBooking(tempId, tempShowId, tempIsReserved, tempRowNo, tempSeatNo, tempPhoneNumber);
            return foundSeatBooking;
        }

        public bool Update(int showingId, List<SeatBooking> newSeatBookings)
        {
            int numRowsUpdated = 0;
            int numBookings = (newSeatBookings != null) ? newSeatBookings.Count : -1;

            string sqlUpdate = "UPDATE SeatBooking set IsReserved = 1, PhoneNumber = @PhoneNumber WHERE IsReserved = 0 AND ShowingID = @ShowingId AND RowNo = @RowNo AND SeatNo = @SeatNo";

            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand CreateCommand = new SqlCommand(sqlUpdate, con))
            {

                con.Open();
                foreach (SeatBooking seatBooking in newSeatBookings)
                {
                    CreateCommand.Parameters.Clear();
                    SqlParameter rowNoParam = new SqlParameter("@RowNo", seatBooking.RowNo);
                    SqlParameter seatNoParam = new SqlParameter("@SeatNo", seatBooking.SeatNo);
                    SqlParameter showingIdParam = new SqlParameter("@ShowingID", showingId);
                    SqlParameter phoneNumberParam = new SqlParameter("@PhoneNumber", seatBooking.PhoneNumber);

                    //Adds the above parameter to a Command

                    CreateCommand.Parameters.Add(rowNoParam);
                    CreateCommand.Parameters.Add(seatNoParam);
                    CreateCommand.Parameters.Add(showingIdParam);
                    CreateCommand.Parameters.Add(phoneNumberParam);

                    // Opens the connection
                    
                    // Execute the command, save and read generated key (ID)
                    CreateCommand.ExecuteScalar();
                }

                
            }
            return (numRowsUpdated == numBookings);
        }
    }
}
