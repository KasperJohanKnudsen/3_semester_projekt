using System;
using System.Collections.Generic;
using System.Text;
using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using Xunit;
using Xunit.Abstractions;

namespace CinemaDataTest
{
    public class TestBookingDataAccess
    {
        [Fact]
        public void TestCreateBooking()
        {
            //Arrange
            //User user = _userAccess.GetById(1);
            Showing showing = _showingAccess.GetById(1);
            SeatBooking seatBooking = _seatBookingAccess.GetById(15);
            string seatsBooked = "Row: " + seatBooking.RowNo.ToString() + " SeatNumber: " +seatBooking.SeatNo.ToString();
            decimal price = 200.0m;
 
            Booking insertBooking = new Booking(555, 1, price, seatsBooked, seatBooking.ID);

            int showId = 1;
            List<SeatBooking> seatBookings = new List<SeatBooking>();
            SeatBooking seatBooking1 = new SeatBooking(15, showId, false, 1, 9, 90122);
            seatBookings.Add(seatBooking1);
            //Act
            _bookingAccess.Create(insertBooking, showId, seatBookings);
            //int showingId, bool isReserved, int rowNo, int seatNo, int phoneNumber

            //Assert

        }

        private readonly ITestOutputHelper extraOutput;
        readonly private BookingDatabaseAccess _bookingAccess;

        readonly private ICRUD<Showing> _showingAccess;
        readonly private ICRUD<SeatBooking> _seatBookingAccess;
        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestBookingDataAccess(ITestOutputHelper output)
        {
            this.extraOutput = output;
            _bookingAccess = new BookingDatabaseAccess(_connectionString);
            _showingAccess = new ShowingDatabaseAccess(_connectionString);
            _seatBookingAccess = new SeatBookingDatabaseAccess(_connectionString);
        }
            
    }
}
