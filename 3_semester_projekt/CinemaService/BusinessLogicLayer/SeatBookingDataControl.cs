using APIAccess.ControlLayer;
using CinemaData.DatabaseLayer;
using CinemaData.ModelLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.BusinessLogicLayer
{
    public class SeatBookingDataControl : IDataControl<SeatBooking>
    {
        private readonly ShowingDatabaseAccess _sAccess;

        public SeatBookingDataControl(IConfiguration inConfiguration)
        {
            _sAccess = new ShowingDatabaseAccess(inConfiguration);
        }
        public int Add(SeatBooking entityToAdd)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SeatBooking> GetSeatBookings(int showingId)
        {
            List<SeatBooking> foundSeatBookings;
            try
            {
                foundSeatBookings = _sAccess.GetSeatBookingByShowingId(showingId);
            }
            catch (Exception e)
            {
                foundSeatBookings = null;
                Console.WriteLine(e.Message);
            }
            return foundSeatBookings;
        }

        public SeatBooking GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Put(SeatBooking entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SeatBooking> Get()
        {
            throw new NotImplementedException();
        }
    }
}
