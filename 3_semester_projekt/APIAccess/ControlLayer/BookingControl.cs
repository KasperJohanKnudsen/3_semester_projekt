using APIAccess.ServiceLayer;
using APIAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APIAccess.ControlLayer
{
    public class BookingControl : IDataControl<Booking>
    {
        BookingService _bAccess;

        public BookingControl()
        {
            _bAccess = new BookingService();
        }

        public async Task<int> Add(Booking aBooking)
        {
            int insertedId = await _bAccess.SaveBooking(aBooking);
            return insertedId;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Booking Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Booking>> Get()
        {
            List<Booking> foundBookings = await _bAccess.GetBookings();
            return foundBookings;
        }

        public bool Put(Booking entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
    
}
