using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CinemaDataTest
{
    public class TestMovieDataAccess
    {

        [Fact]
        public void TestGetMovieById()
        {
            // Arrange
            Movie foundMovie;

            // Act
            foundMovie = _movieAccess.GetById(1);

            // Assert
            Assert.True(foundMovie.ID == 1);



            extraOutput.WriteLine(foundMovie.ToString());

        }



        private readonly ITestOutputHelper extraOutput;
        readonly private ICRUD<Movie> _movieAccess;
        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestMovieDataAccess(ITestOutputHelper output)
        {
            this.extraOutput = output;
            _movieAccess = new MovieDatabaseAccess(_connectionString);
        }
    }
}
