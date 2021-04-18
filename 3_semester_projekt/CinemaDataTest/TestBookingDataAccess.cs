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
            User user = _userAccess.GetById(1);
            Showing showing = _showingAccess.GetById(1);
            SeatBooking seatBooking = _seatBookingAccess.GetById(1);
            string seatsBooked = "Row: " + seatBooking.RowNo.ToString() + " SeatNumber: " +seatBooking.SeatNo.ToString();
            decimal price = 200.0m;
 
            Booking insertBooking = new Booking(user.ID, showing.ID, price, seatsBooked, seatBooking.ID);


            //Act
            _bookingAccess.Create(insertBooking);

            //Assert
            
        }

        private readonly ITestOutputHelper extraOutput;
        readonly private ICRUD<Booking> _bookingAccess;
        readonly private ICRUD<User> _userAccess;
        readonly private ICRUD<Showing> _showingAccess;
        readonly private ICRUD<SeatBooking> _seatBookingAccess;
        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestBookingDataAccess(ITestOutputHelper output)
        {
            this.extraOutput = output;
            _bookingAccess = new BookingDatabaseAccess(_connectionString);
            _userAccess = new UserDatabaseAccess(_connectionString);
            _showingAccess = new ShowingDatabaseAccess(_connectionString);
            _seatBookingAccess = new SeatBookingDatabaseAccess(_connectionString);
        }
            
    }
}
