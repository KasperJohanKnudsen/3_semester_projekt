using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClientMVC.Models
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
    }
}
