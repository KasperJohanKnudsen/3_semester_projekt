using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClientMVC.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        

        public UserProfile() { }
        public UserProfile(int phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public UserProfile(int id, int phoneNumber) : this(phoneNumber)
        {
            Id = id;
            PhoneNumber = phoneNumber;
        }
    }
}
