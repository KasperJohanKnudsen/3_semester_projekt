using DesktopClient.ModelLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.ServiceLayer
{
    class ShowingServiceAccess
    {
        static readonly string restUrl = "http://localhost:35452/api/showings";
        readonly HttpClient _httpClient;

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public ShowingServiceAccess()
        {
            _httpClient = new HttpClient();
        }

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
    }
}
