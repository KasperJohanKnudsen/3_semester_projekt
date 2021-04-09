using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaData.ModelLayer;

namespace CinemaService.BusinesslogicLayer
{
    public interface IBookingData
    {
        Booking Get(int id);
        List<Booking> Get();
        int Add(Booking bookingToAdd);
        bool Put(Booking bookingToUpdate);
        bool Delete(int id);
    }
}
