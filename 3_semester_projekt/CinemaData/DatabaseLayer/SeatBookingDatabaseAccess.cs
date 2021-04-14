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
        public int Create(SeatBooking entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SeatBooking> GetAll()
        {
            throw new NotImplementedException();
        }

        public SeatBooking GetById(int findId)
        {
            SeatBooking foundSeatBooking = null;
            //
            string queryString = "select SeatBookingID, IsReserved, RowNo, SeatNo from SeatBooking where SeatBookingID = @SeatBookingID";
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


            tempId = productReader.GetInt32(productReader.GetOrdinal("SeatBookingID"));
            tempIsReserved = productReader.GetBoolean(productReader.GetOrdinal("IsReserved"));
            tempRowNo = productReader.GetInt32(productReader.GetOrdinal("RowNo"));
            tempSeatNo = productReader.GetInt32(productReader.GetOrdinal("SeatNo"));


            //Build the booking with the values from the database
            foundSeatBooking = new SeatBooking(tempId, tempIsReserved, tempRowNo, tempSeatNo);
            return foundSeatBooking;
        }

        public bool Update(SeatBooking entity)
        {
            throw new NotImplementedException();
        }
    }
}
