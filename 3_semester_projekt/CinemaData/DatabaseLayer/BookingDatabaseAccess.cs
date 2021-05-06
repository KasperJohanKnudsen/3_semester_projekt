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
        
        private static int _delay = 20000;
        public int Create(Booking aBooking, int showId, List<SeatBooking> newReservations)
        {
            // I think we use -1 because then we are sure that it is not from the database if it returns that
            int insertedId = -1;


            string insertString = "insert into Booking(PhoneNumber, ShowingId, Price, SeatBookingID) OUTPUT INSERTED.BookingID values (@PhoneNumber, @ShowingID, @Price, @SeatBookingId)";

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    //Create the command with a sql script

                    // Opens the connection
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
                    {
                        using (SqlCommand CreateCommand = new SqlCommand(insertString, con, transaction))
                        {

                            int rowNo;
                            int seatNo;
                            SeatBooking foundSeatBooking = new SeatBooking();
                            //bool isAlreadyReserved = false;

                            string queryString = "select SeatBookingID, IsReserved, RowNo, SeatNo, ShowingID, PhoneNumber from SeatBooking where RowNo = @RowNo AND SeatNo = @SeatNo";
                            using (SqlCommand readCommand = new SqlCommand(queryString, con, transaction))
                            {


                                foreach (SeatBooking sb in newReservations)
                                {
                                    ReadSeatbookings(aBooking, out rowNo, out seatNo, out foundSeatBooking, readCommand, sb);
                                }


                                if (foundSeatBooking.IsReserved)
                                {
                                    ThreadStatus(aBooking, " is rolled back");
                                    transaction.Rollback();
                                    return -1;
                                }
                            }
                            //_delay -= 10000;
                            //System.Threading.Thread.Sleep(_delay);

                            foreach (SeatBooking seatBooking in newReservations)
                            {
                                CreateBookings(aBooking, out insertedId, CreateCommand, out rowNo, out seatNo, seatBooking);
                            }

                            //bool wentOk = _sbAccess.Update(showId, newReservations);

                            UpdateSeatBookings(aBooking, showId, newReservations, con, transaction);
                            transaction.Commit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            // Returns the new id, if it's -1 something is wrong
            return insertedId;
        }

        private static void ThreadStatus(Booking aBooking, string workPerformed)
        {
            System.Diagnostics.Debug.WriteLine(System.Threading.Thread.CurrentThread.Name + workPerformed + aBooking.PhoneNumber + DateTime.Now.ToLongTimeString());
        }

        private static void ReadSeatbookings(Booking aBooking, out int rowNo, out int seatNo, out SeatBooking foundSeatBooking, SqlCommand readCommand, SeatBooking sb)
        {
            rowNo = sb.RowNo;
            seatNo = sb.SeatNo;

            foundSeatBooking = null;

            // using (SqlConnection con2 = new SqlConnection(_connectionString))

            // Put the Id parameter into the command so that we know which room to read
            readCommand.Parameters.Clear();
            SqlParameter rowNoParam = new SqlParameter("@RowNo", rowNo);
            SqlParameter seatNoParam = new SqlParameter("@SeatNo", seatNo);
            readCommand.Parameters.Add(rowNoParam);
            readCommand.Parameters.Add(seatNoParam);

            // con2.Open();
            // SQLDatareader reads data from the database

            SqlDataReader productReader = readCommand.ExecuteReader();
            if (productReader.HasRows)
            {
                while (productReader.Read())
                {


                    int tempId;
                    bool tempIsReserved;
                    int tempRowNo;
                    int tempSeatNo;
                    int tempShowId;
                    int tempPhoneNumber = productReader["PhoneNumber"] as int? ?? -1;

                    ThreadStatus(aBooking, " is reading ");
                    tempId = productReader.GetInt32(productReader.GetOrdinal("SeatBookingID"));
                    tempIsReserved = productReader.GetBoolean(productReader.GetOrdinal("IsReserved"));
                    tempRowNo = productReader.GetInt32(productReader.GetOrdinal("RowNo"));
                    tempSeatNo = productReader.GetInt32(productReader.GetOrdinal("SeatNo"));
                    tempShowId = productReader.GetInt32(productReader.GetOrdinal("ShowingID"));



                    //Build the booking with the values from the database
                    foundSeatBooking = new SeatBooking(tempId, tempShowId, tempIsReserved, tempRowNo, tempSeatNo, tempPhoneNumber);

                }
            }
            productReader.Close();
        }

        private void CreateBookings(Booking aBooking, out int insertedId, SqlCommand CreateCommand, out int rowNo, out int seatNo, SeatBooking seatBooking)
        {
            rowNo = seatBooking.RowNo;
            seatNo = seatBooking.SeatNo;


            CreateCommand.Parameters.Clear();
            // Prepare SQL
            // Prepares a parameters inside the database to receive a property from the class
            SqlParameter PhoneNumberParam = new SqlParameter("@PhoneNumber", aBooking.PhoneNumber);
            SqlParameter showingIdParam = new SqlParameter("@ShowingID", aBooking.ShowingId);
            SqlParameter priceParam = new SqlParameter("@Price", aBooking.Price);


            //aBooking.SeatsBooked.Substring(0, 2);

            int seatBookingId = _sbAccess.GetByRowNoAndSeatNo(rowNo, seatNo).ID;


            SqlParameter seatBookingIdParam = new SqlParameter("@SeatBookingID", seatBookingId);


            //Adds the above parameter to a Command
            CreateCommand.Parameters.Add(PhoneNumberParam);
            CreateCommand.Parameters.Add(showingIdParam);
            CreateCommand.Parameters.Add(priceParam);
            CreateCommand.Parameters.Add(seatBookingIdParam);

            ThreadStatus(aBooking, " is creating booking ");

            // Execute the command, save and read generated key (ID)
            insertedId = (int)CreateCommand.ExecuteScalar();
        }

        private static void UpdateSeatBookings(Booking aBooking, int showId, List<SeatBooking> newReservations, SqlConnection con, SqlTransaction transaction)
        {
            int numRowsUpdated = 0;
            int numBookings = (newReservations != null) ? newReservations.Count : -1;

            string sqlUpdate = "UPDATE SeatBooking set IsReserved = 1, PhoneNumber = @PhoneNumber WHERE IsReserved = 0 AND ShowingID = @ShowingId AND RowNo = @RowNo AND SeatNo = @SeatNo";
            using (SqlCommand UpdateCommand = new SqlCommand(sqlUpdate, con, transaction))
            {
                foreach (SeatBooking seatBooking in newReservations)
                {
                    UpdateCommand.Parameters.Clear();
                    SqlParameter rowNoParam = new SqlParameter("@RowNo", seatBooking.RowNo);
                    SqlParameter seatNoParam = new SqlParameter("@SeatNo", seatBooking.SeatNo);
                    SqlParameter showingIdParam = new SqlParameter("@ShowingID", showId);
                    SqlParameter phoneNumberParam = new SqlParameter("@PhoneNumber", seatBooking.PhoneNumber);

                    //Adds the above parameter to a Command

                    UpdateCommand.Parameters.Add(rowNoParam);
                    UpdateCommand.Parameters.Add(seatNoParam);
                    UpdateCommand.Parameters.Add(showingIdParam);
                    UpdateCommand.Parameters.Add(phoneNumberParam);
                    ThreadStatus(aBooking, " is updating seatbooking ");
                    // Opens the connection

                    // Execute the command, save and read generated key (ID)
                    UpdateCommand.ExecuteScalar();
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


            string queryString = "select BookingID, PhoneNumber, ShowingID, Price, SeatBookingID from Booking";
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
            string queryString = "select BookingID, PhoneNumber, ShowingID, Price, SeatBookingID from Booking where BookingID = @BookingID";
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
            int tempSeatBookingId;


            tempId = productReader.GetInt32(productReader.GetOrdinal("BookingID"));
            tempPhoneNumber = productReader.GetInt32(productReader.GetOrdinal("PhoneNumber"));
            tempShowingId = productReader.GetInt32(productReader.GetOrdinal("ShowingID"));
            tempPrice = productReader.GetDecimal(productReader.GetOrdinal("Price"));

            tempSeatBookingId = productReader.GetInt32(productReader.GetOrdinal("SeatBookingID"));

            //Build the booking with the values from the database
            foundBooking = new Booking(tempId, tempPhoneNumber, tempShowingId, tempPrice, tempSeatBookingId);
            return foundBooking;
        }


        public bool Update(int id, List<Booking> updateEntities)
        {
            throw new NotImplementedException();
        }
    }

}
