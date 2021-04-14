using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CinemaDataTest
{
    public class TestTheaterDataAccess
    {
        [Fact]
        public void TestGetTheaterById()
        {
            // Arrange
            Theater foundTheater;

            // Act
            foundTheater = _theaterAccess.GetById(10);

            // Assert
            Assert.True(foundTheater.ID == 10);



            extraOutput.WriteLine(foundTheater.ToString());

        }



        private readonly ITestOutputHelper extraOutput;
        readonly private ICRUD<Theater> _theaterAccess;
        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestTheaterDataAccess(ITestOutputHelper output)
        {
            this.extraOutput = output;
            _theaterAccess = new TheaterDatabaseAccess(_connectionString);
        }
    }
}
