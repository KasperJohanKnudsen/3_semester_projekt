using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class SeatBooking
    {
        public int ID { get; set; }
        public bool IsReserved { get; set; }
        public int RowNo { get; set; }
        public int SeatNo { get; set; }


        public SeatBooking() { }
        public SeatBooking(bool isReserved, int rowNo, int seatNo)
        {
            IsReserved = isReserved;
            RowNo = rowNo;
            SeatNo = seatNo;
        }
        public SeatBooking(int id, bool isReserved, int rowNo, int seatNo)
        {
            ID = id;
            IsReserved = isReserved;
            RowNo = rowNo;
            SeatNo = seatNo;
        }

    }
}
