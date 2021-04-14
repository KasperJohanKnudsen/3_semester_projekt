using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class User
    {
        public int UserId { get; set; }
        public int PhoneNumber { get; set; }

        public User() { }
        public User(int phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public User(int userId, int phoneNumber) : this(phoneNumber)
        {
            UserId = userId;
            PhoneNumber = phoneNumber;
        }

    }
}
