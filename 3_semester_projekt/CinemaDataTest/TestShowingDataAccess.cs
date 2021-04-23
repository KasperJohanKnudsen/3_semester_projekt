using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CinemaDataTest
{
    
    public class TestShowingDataAccess
    {
        private readonly IConfiguration _configuration;
        


        [Fact]
        public void TestGetShowingById()
        {
            // Arrange
            Showing foundShowing;

            // Act
            foundShowing = _showingAccess.GetById(1);

            // Assert
            Assert.True(foundShowing.ID == 1);

            

            extraOutput.WriteLine(foundShowing.StartTime.ToString());

        }

        [Fact]
        public void TestGetSeatBookingByShowingId()
        {

            // Arrange
            
            List<SeatBooking> foundSeatBookings;
            string output = null;

            // Act
            foundSeatBookings = _sAccess.GetSeatBookingByShowingId(1);

            // Assert
            //Assert.True(foundShowing.ID == 1);

            foreach (SeatBooking item in foundSeatBookings)
            {
                output = item.RowNo.ToString();
            }



            extraOutput.WriteLine(output);

        }

        [Fact]
        public void TestGetShowingViewById()
        {
            // Arrange
            Showing foundShowing;

            // Act
            foundShowing = _sAccess.GetShowingById(1);

            // Assert
            Assert.True(foundShowing.ID == 1);



            extraOutput.WriteLine(foundShowing.ID.ToString());

        }



        private readonly ITestOutputHelper extraOutput;
        readonly private ICRUD<Showing> _showingAccess;
        private ShowingDatabaseAccess _sAccess;


        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestShowingDataAccess(ITestOutputHelper output)
        {
            
            this.extraOutput = output;
            _sAccess = new ShowingDatabaseAccess(_connectionString);
            _showingAccess = new ShowingDatabaseAccess(_connectionString);
        }
    }
}
