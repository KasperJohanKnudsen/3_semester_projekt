using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public string Name { get; set; }

        public bool IsBookingEmpty
        {
            get
            {
                if (String.IsNullOrWhiteSpace(Name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Booking() { }
        public Booking(string name)
        {
            Name = name;
        }
        public Booking(int id, int userId, int roomId, string name) : this(name)
        {
            Id = id;
            UserId = userId;
            RoomId = roomId;
        }
    }
}
