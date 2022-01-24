using Ahoy.Domain.Base;
using Ahoy.Domain.Interfaces.Hotels;
using Ahoy.Domain.Models.Hotels;
using Ahoy.Infrastructure.Application.Factory;
using Ahoy.Infrastructure.Routes;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Infrastructure.Repository.Hotels
{
    public class HotelRepository : IHotelRepository
    {
        private HttpClient _httpClient;

        public async Task<HotelList> HotelList()
        {
            var _URL = APIRouteName.HotelListAPI + "hotel?keyword=PARI&subType=HOTEL_LEISURE&countryCode=FR&lang=EN&max=20";

            HotelList responseBase = null;

            var request = new HttpRequestMessage(HttpMethod.Get, _URL);

            try
            {
                _httpClient = ClientFactory.CreateHttpClient();
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    responseBase = JsonConvert.DeserializeObject<HotelList>(jsonString);
                }
                else
                {
                    return responseBase;

                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return responseBase;

        }
        public async Task<MultiResponse> SearchHotel()
        {
            var _URL = APIRouteName.HotelSearchAPI + "hotel-offers?hotelIds=HLLON101&adults=1&checkInDate=2022-06-20&roomQuantity=1&paymentPolicy=NONE&bestRateOnly=true";

            MultiResponse multiResponse = null;

            var request = new HttpRequestMessage(HttpMethod.Get, _URL);

            try
            {
                _httpClient = ClientFactory.CreateHttpClient();
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    multiResponse = JsonConvert.DeserializeObject<MultiResponse>(jsonString);
                }
                else
                {
                    return multiResponse;

                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return multiResponse;

        }


        public async Task<ResponseBase> BookingHotel(Booking booking)
        {
            var _URL = APIRouteName.BookingAPI + "hotel-bookings";

            var request = new HttpRequestMessage(HttpMethod.Post, _URL);
            ResponseBase responseBase = null;

            if (booking != null)
            {
                request.Content = new StringContent(JsonConvert.SerializeObject(booking), Encoding.UTF8, "application/json");
            }
            try
            {
                _httpClient = ClientFactory.CreateHttpClient();
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {

                    var jsonString = await response.Content.ReadAsStringAsync();
                    responseBase = JsonConvert.DeserializeObject<ResponseBase>(jsonString);
                }
                else
                {
                    return responseBase;

                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return responseBase;

        }

    }
}
