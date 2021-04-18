using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Admin() { }
        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Admin(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

    }
}
