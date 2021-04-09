using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopClient.ModelLayer
{
    public class Booking
    {
        public string Name { get; set; }

        public Booking() { }
        public Booking(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            string bText = Name;
            
            return bText;
        }
    }
}
