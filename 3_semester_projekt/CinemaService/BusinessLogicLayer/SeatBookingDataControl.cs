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
        private readonly ShowingDatabaseAccess _showingAccess;
        private readonly SeatBookingDatabaseAccess _seatAccess;
        

        public SeatBookingDataControl(IConfiguration inConfiguration)
        {
            _showingAccess = new ShowingDatabaseAccess(inConfiguration);
            _seatAccess = new SeatBookingDatabaseAccess(inConfiguration);
        }
        public int Add(SeatBooking newSeatBooking)
        {
            int insertedId;
            try
            {
                // Assignment below needs to be removed when hardcoding it can be avoided
                newSeatBooking.ShowingId = new Showing().FindIdInList(_showingAccess.GetAll());
                
                
                insertedId = _seatAccess.Create(newSeatBooking);
            }
            catch
            {
                insertedId = -1;
            }
            return insertedId;
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
                foundSeatBookings = _showingAccess.GetSeatBookingByShowingId(showingId);
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

        public bool Put(int showingId, List<SeatBooking> newSeatBookings)
        {
            bool wasOk;
            try
            {
                wasOk = _seatAccess.Update(showingId, newSeatBookings);
                /*
                List<SeatBookingBuffer> sbBufferList = new List<SeatBookingBuffer>();

                foreach (SeatBooking seatBooking in newSeatBookings)
                {
                    int phoneNumber = seatBooking.PhoneNumber;
                    int seatsBooked = seatBooking.RowNo + seatBooking.SeatNo;


                    SeatBookingBuffer sbBuffer = new SeatBookingBuffer(showingId, phoneNumber, seatsBooked.ToString());
                    sbBufferList.Add(sbBuffer);
                }
                */
                
            }
            catch
            {
                wasOk = false;
            }
            return wasOk;
        }

        public IEnumerable<SeatBooking> Get()
        {
            throw new NotImplementedException();
        }
    }
}
