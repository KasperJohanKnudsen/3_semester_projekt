using CinemaData.ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CinemaData.DatabaseLayer
{
    public class SeatBookingDatabaseAccess : ICRUD<SeatBooking>
    {
        public int Create(SeatBooking entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SeatBooking> GetAll()
        {
            throw new NotImplementedException();
        }

        public SeatBooking GetById(int id)
        {
            throw new NotImplementedException();
        }

        public SeatBooking GetFromReader(SqlDataReader productReader)
        {
            throw new NotImplementedException();
        }

        public bool Update(SeatBooking entity)
        {
            throw new NotImplementedException();
        }
    }
}
