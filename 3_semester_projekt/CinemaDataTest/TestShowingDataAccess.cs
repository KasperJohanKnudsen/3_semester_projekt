using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CinemaDataTest
{
    public class TestShowingDataAccess
    {
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



        private readonly ITestOutputHelper extraOutput;
        readonly private ICRUD<Showing> _showingAccess;
        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestShowingDataAccess(ITestOutputHelper output)
        {
            this.extraOutput = output;
            _showingAccess = new ShowingDatabaseAccess(_connectionString);
        }
    }
}
