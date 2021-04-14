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
            Booking insertBooking = new Booking(1, 1, 100.0m, 2, 1);


            //Act
            _bookingAccess.CreateBooking(insertBooking);

            //Assert
            
        }

        private readonly ITestOutputHelper extraOutput;
        readonly private IBookingAccess _bookingAccess;
        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestBookingDataAccess(ITestOutputHelper output)
        {
            this.extraOutput = output;
            _bookingAccess = new BookingDatabaseAccess(_connectionString);
        }
            
    }
}
