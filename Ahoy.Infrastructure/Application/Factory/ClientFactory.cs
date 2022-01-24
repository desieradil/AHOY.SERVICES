using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Infrastructure.Application.Factory
{
    public sealed class ClientFactory
    {
        private static HttpClient _httpClient = null;

        private static readonly object Padlock = new object();

        public static HttpClient CreateHttpClient()
        {
            string token = getToken();

            string baseUrl = "https://test.api.amadeus.com/";
            lock (Padlock)
            {
                if (!(_httpClient is null)
                ) // && !string.IsNullOrWhiteSpace(token)) No need to double check if auth token is empty api will return with error code we can not handle it here so no point of checking or catching whether token is empty or not 
                {
                    _httpClient.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token);
                    return _httpClient;
                }

                _httpClient = new HttpClient()
                {
                    BaseAddress = new Uri(baseUrl)
                };
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
                return _httpClient;
            }


        }

        private static string getToken()
        {
            const string apikey = "ADw503Cr6sCG2LbaHAu7xe5r9jQefsCG";
            const string apisecret = "o9g0dW42jkTJGbvP";
            const string tokenURL = "https://test.api.amadeus.com/v1/security/oauth2/token";


            string postData = $"grant_type=client_credentials&client_id={apikey}&client_secret={apisecret}";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(tokenURL);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "");
            request.Content = new StringContent(postData,
                                    Encoding.UTF8,
                                    "application/x-www-form-urlencoded");

            Task<HttpResponseMessage> response = client.SendAsync(request);
            if (response.Result.IsSuccessStatusCode)
            {
                string myJsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Result.Content.ReadAsStringAsync().Result).ToString();
                JObject jsonObject = JObject.Parse(myJsonResponse);
                client.Dispose();

                string token = (string)jsonObject["access_token"];
                return token;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.Result.StatusCode, response.Result.ReasonPhrase);
                return response.Result.ReasonPhrase;
            }
        }

    }
}
