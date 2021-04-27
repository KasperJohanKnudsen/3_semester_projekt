using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CinemaDataTest
{
    public class TestSeatBookingDataAccess
    {


        [Fact]
        public void TestCreateSeatBooking()
        {
            //Arrange
            int phoneNumber = 112;
            Showing showing = _showingAccess.GetById(1);
            bool isReserved = true;
            int rowNo = 52;
            int seatNo = 1;

            SeatBooking insertSeatBooking = new SeatBooking(showing.ID, isReserved, rowNo, seatNo, phoneNumber);

            

            //Act
            _seatBookingAccess.Create(insertSeatBooking);

            //Assert

        }

        [Fact]
        public void TestGetSeatBookingById()
        {
            // Arrange
            SeatBooking foundSeatBooking;

            // Act
            foundSeatBooking = _seatBookingAccess.GetById(1);

            // Assert
            Assert.True(foundSeatBooking.ID == 1);



            extraOutput.WriteLine(foundSeatBooking.ToString());

        }



        private readonly ITestOutputHelper extraOutput;
        readonly private ICRUD<SeatBooking> _seatBookingAccess;
        readonly private ICRUD<Showing> _showingAccess;
        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestSeatBookingDataAccess(ITestOutputHelper output)
        {
            this.extraOutput = output;
            _seatBookingAccess = new SeatBookingDatabaseAccess(_connectionString);
            _showingAccess = new ShowingDatabaseAccess(_connectionString);
        }
    }
}
