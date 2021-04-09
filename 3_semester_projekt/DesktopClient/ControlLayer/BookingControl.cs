﻿using DesktopClient.ServiceLayer;
using DesktopClient.ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.ControlLayer
{
    public class BookingControl
    {
        BookingServiceAccess _bAccess;

        public BookingControl()
        {
            _bAccess = new BookingServiceAccess();
        }

        public async Task<List<Booking>> GetAllBookings()
        {
            List<Booking> foundBookings = await _bAccess.GetBookings();
            return foundBookings;
            

            
        }

        public async Task<int> SaveBooking(string name)
        {
            Booking newBooking = new Booking(name);
            int insertedId = await _bAccess.SaveBooking(newBooking);
            return insertedId;
        }
    }
    
}
