using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class SeatBooking : Model
    {
        //public int ID { get; set; }
        public int ShowingId { get; set; }
        public bool IsReserved { get; set; }
        public int RowNo { get; set; }
        public int SeatNo { get; set; }
        public int PhoneNumber { get; set; }


        public SeatBooking() { }
        public SeatBooking(int showingId, bool isReserved, int rowNo, int seatNo)
        {
            ShowingId = showingId;
            IsReserved = isReserved;
            RowNo = rowNo;
            SeatNo = seatNo;
        }
        public SeatBooking(int showingId, bool isReserved, int rowNo, int seatNo, int phoneNumber)
        {
            ShowingId = showingId;
            IsReserved = isReserved;
            RowNo = rowNo;
            SeatNo = seatNo;
            PhoneNumber = phoneNumber;
        }
        public SeatBooking(int id, int showingId, bool isReserved, int rowNo, int seatNo, int phoneNumber)
        {
            ID = id;
            ShowingId = showingId;
            IsReserved = isReserved;
            RowNo = rowNo;
            SeatNo = seatNo;
            PhoneNumber = phoneNumber;
        }

    }
}
