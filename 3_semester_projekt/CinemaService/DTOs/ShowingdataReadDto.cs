using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaService.DTOs
{
    public class ShowingdataReadDto
    {
        public string MovieName { get; set; }
        public string Theater { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Date { get; set; }
        public string ShowingOrder { get; set; }

        public ShowingdataReadDto() { }

        public ShowingdataReadDto(string movieName, string theater, DateTime startTime, DateTime date) 
        {
            MovieName = movieName;
            Theater = theater;
            StartTime = startTime;
            Date = date;
        }
    }
}
