using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class SeatBooking
    {
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

    }
}
