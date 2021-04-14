using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CinemaDataTest
{
    public class TestUserDataAccess
    {
        [Fact]
        public void TestGetUserById()
        {
            // Arrange
            User foundUser;

            // Act
            foundUser = _userAccess.GetById(1);

            // Assert
            Assert.True(foundUser.UserId == 1);

            extraOutput.WriteLine(foundUser.PhoneNumber.ToString());

            

        }



        private readonly ITestOutputHelper extraOutput;
        readonly private ICRUD<User> _userAccess;
        readonly string _connectionString = "Server=localhost; Integrated " + "Security=true; Database=CinemaCenter";

        public TestUserDataAccess(ITestOutputHelper output)
        {
            this.extraOutput = output;
            _userAccess = new UserDatabaseAccess(_connectionString);
        }
    }
}
