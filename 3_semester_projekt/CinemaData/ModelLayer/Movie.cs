using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public Movie() { }
        public Movie(string title, string duration)
        {
            Title = title;
            Duration = duration;
        }

        public Movie(int id, string title, string duration)
        {
            ID = id;
            Title = title;
            Duration = duration;
        }
    }
}
