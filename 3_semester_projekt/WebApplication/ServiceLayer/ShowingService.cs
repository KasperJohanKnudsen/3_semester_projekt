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
    public class ShowingService
    {
        static readonly string restUrl = "http://localhost:35452/api/movies";
        readonly HttpClient _httpClient;

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public ShowingService()
        {
            _httpClient = new HttpClient();
        }
        

        public async Task<Showing> GetShowing(int showingId, bool includeSeatReservations)
        {
            Showing retrievedShowing;

            // Create URI
            string useRestUrl = restUrl + $"/showings/{showingId}/?includeReservations={includeSeatReservations}";
            var uri = new Uri(string.Format(useRestUrl));

            //
            try
            {
                var response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    retrievedShowing = JsonConvert.DeserializeObject<Showing>(content);
                }
                else
                {
                    throw (new Exception());
                }
            }
            catch
            {
                throw;
            }
            return retrievedShowing;
        }

        public async Task<bool> UpdateSeatBookings(int showingId, List<SeatBooking> newReservations)
        {
            bool changedOk;

            string useRestUrl = null;
            string jsonString = null;
            HttpResponseMessage response = null;

            useRestUrl = restUrl + $"/showings/{showingId}/seatbookings";

            try
            {
                var uri = new Uri(string.Format(useRestUrl, string.Empty));
                jsonString = JsonConvert.SerializeObject(newReservations);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                response = await _httpClient.PutAsync(uri, content);

                if (response.IsSuccessStatusCode)
                {
                    changedOk = true;
                }
                else
                {
                    changedOk = false;
                }
            }
            catch
            {
                changedOk = false;
            }

            return changedOk;
        }

    }

    /*
    public async Task<List<Showing>> GetShowings(int id = -1)
    {
        List<Showing> showingsFromService = null;
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
                    Showing foundShowing = JsonConvert.DeserializeObject<Showing>(content);
                    if (foundShowing != null)
                    {
                        showingsFromService = new List<Showing>() { foundShowing };
                    }
                }
                else
                {
                    showingsFromService = JsonConvert.DeserializeObject<List<Showing>>(content);
                }
            }
            else
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    showingsFromService = new List<Showing>();
                }
                else
                {
                    showingsFromService = null;
                }
            }
        }
        catch
        {
            showingsFromService = null;
        }
        return showingsFromService;

    }
    */
    /*
    public async Task<Showing> GetShowing(int showingId, bool includeSeatReservations)
    {
        Showing retrievedShowing;

        // Create URI
        string useRestUrl = restUrl + $"/showing/{showingId}/?includeReservations={includeSeatReservations}";
        var uri = new Uri(string.Format(useRestUrl));

        //
        try
        {
            var response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                retrievedShowing = JsonConvert.DeserializeObject<Showing>(content);
            }
            else
            {
                throw (new Exception());
            }
        }
        catch
        {
            throw;
        }
        return retrievedShowing;
    }
    */
    /*
    public async Task<int> SaveShowing(Showing showingToSave)
        {
            int insertedShowingId;
            string useRestUrl = restUrl;
            var uri = new Uri(string.Format(useRestUrl, string.Empty));
            //
            try
            {
                var json = JsonConvert.SerializeObject(showingToSave);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await _httpClient.PostAsync(uri, content);
                string resultingIdString = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Int32.TryParse(resultingIdString, out insertedShowingId);
                }
                else
                {
                    insertedShowingId = -2;
                }
            }
            catch
            {
                insertedShowingId = -3;
            }
            return insertedShowingId;
        }
    
    }
    */
}
