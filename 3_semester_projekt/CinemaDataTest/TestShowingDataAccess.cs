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
        public void TestGetShowingAll() {
            // Arrange
            List<Showing> foundShowings = new List<Showing>();
            string output = null;
            // Act
            foundShowings = (List<Showing>)_showingAccess.GetAll();

            // Assert
            //Assert.True();

            foreach (Showing item in foundShowings) {
                output = item.ID.ToString();
            }



            extraOutput.WriteLine(output);

        }

        [Fact]
        public void TestCreateShowing() {
            // Arrange
            Showing aShowing = new Showing(3, 10, DateTime.Now, DateTime.Now);

            // Act
            _showingAccess.Create(aShowing);

            // Assert
            Assert.True(aShowing.MovieId == 3);


            // MovieId, TheaterID, StartTime, Date, SeatBookingID


            //extraOutput.WriteLine(foundShowing.StartTime.ToString());

        }

        [Fact]
        public void TestDeleteShowingById()
        {
            // Arrange
            int Insertedid = 12;

            // Act
            _showingAccess.Delete(Insertedid);

            // Assert
            



            extraOutput.WriteLine(_showingAccess.GetById(12).ToString());

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
            foundShowing = _sAccess.GetShowingById(6);

            // Assert
            //Assert.True(foundShowing.ID == 6);



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
