using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaData.ModelLayer
{
    public class Movie
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public Movie() { }
        public Movie(string title, string duration)
        {
            Title = title;
            Duration = duration;
        }

    }
}
