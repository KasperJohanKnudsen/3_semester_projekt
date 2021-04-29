using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebClientMVC.Models;

namespace WebClientMVC.ServiceLayer
{
    public class BookingService
    {
        static readonly string restUrl = "http://localhost:35452/api/bookings";
        readonly HttpClient _httpClient;

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public BookingService()
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

            try
            {
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
                    else
                    {
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
        public async Task<int> SaveBooking(int showingId, string seatsBooked, int phoneNumber)
        {
            int insertedBookingId;
            string useRestUrl = restUrl;
            var uri = new Uri(string.Format(useRestUrl, string.Empty));
            //

            Booking aBooking = new Booking(phoneNumber, seatsBooked, showingId);

            try
            {
                var json = JsonConvert.SerializeObject(aBooking);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await _httpClient.PostAsync(uri, content);
                string resultingIdString = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Int32.TryParse(resultingIdString, out insertedBookingId);
                }
                else
                {
                    insertedBookingId = -2;
                }
            }
            catch
            {
                insertedBookingId = -3;
            }
            return insertedBookingId;
        }
    }
}
