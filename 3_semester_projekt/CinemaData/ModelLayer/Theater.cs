using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Theater
    {
        public int ID { get; set; }
        public int Seats { get; set; }
        public string TheaterName { get; set; }
        public int NoOfRows { get; set; }
        public int SeatsPerRow { get; set; }


        public Theater() { }
        public Theater(int seats, string theaterName, int noOfRows, int seatsPerRow)
        {
            Seats = seats;
            TheaterName = theaterName;
            NoOfRows = noOfRows;
            SeatsPerRow = seatsPerRow;
        }

        public Theater(int id, int seats, string theaterName, int noOfRows, int seatsPerRow)
        {
            ID = id;
            Seats = seats;
            TheaterName = theaterName;
            NoOfRows = noOfRows;
            SeatsPerRow = seatsPerRow;
        }


    }
}
