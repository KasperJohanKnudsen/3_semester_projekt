using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DesktopClient.ModelLayer;
using Newtonsoft.Json;

namespace DesktopClient.ServiceLayer
{
    public class BookingServiceAccess
    {
        static readonly string restUrl = "http://localhost:35452/api/bookings";
        readonly HttpClient _httpClient;

        public BookingServiceAccess()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Booking>> GetBookings(int id = -1)
        {
            List<Booking> bookingsFromService = null;
            // api/persons/{id}
            string useRestUrl = restUrl;
            bool hasValidId = (id > 0);
            if (hasValidId) 
            {
                useRestUrl += id;
            }
            var uri = new Uri(string.Format(useRestUrl));
            
            try {
                var response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode) 
                {
                    var content = await response.Content.ReadAsStringAsync();
                    if (hasValidId) 
                    {
                        Booking foundBooking = JsonConvert.DeserializeObject<Booking>(content);                        
                        if (foundBooking != null) 
                        {
                            bookingsFromService = new List<Booking>() { foundBooking };
                        }
                    }
                    else 
                    {
                        bookingsFromService = JsonConvert.DeserializeObject<List<Booking>>(content);
                    }
                }
                else 
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent) 
                    {
                        bookingsFromService = new List<Booking>();
                    }
                    else {
                        bookingsFromService = null;
                    }
                }
            }
            catch 
            {
                bookingsFromService = null;
            }
            return bookingsFromService;

        }

        public async Task<int> SaveBooking(Booking bookingToSave)
        {
            return 0;
        }

    }
}
