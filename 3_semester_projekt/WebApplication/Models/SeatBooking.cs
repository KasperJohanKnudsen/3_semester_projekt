using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClientMVC.Models
{
    public class SeatBooking
    {
        public int ShowingID { get; set; }
        public bool IsReserved { get; set; }
        public int RowNo { get; set; }
        public int SeatNo { get; set; }


        public SeatBooking() { }
        public SeatBooking(int showingId, bool isReserved, int rowNo, int seatNo)
        {
            ShowingID = showingId;
            IsReserved = isReserved;
            RowNo = rowNo;
            SeatNo = seatNo;
        }

        public int GetReservedValue()
        {
            int resAsInt = Convert.ToInt32(IsReserved);
            return resAsInt;
        }
    }
}
