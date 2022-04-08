using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IISHelper
{
    public class Client
    {
        private readonly HttpClient _HttpClient;

        public Client()
        {
            _HttpClient = new HttpClient();
        }

        public static async Task<(HttpResponseMessage, Cookie)> TryAuth(string UserName, string Password)
        {
            var query = "https://iis.bsuir.by/api/v1/auth/login";

            try
            {
                var cookies = new CookieContainer();
                var httpClient = new HttpClient(new HttpClientHandler { CookieContainer = cookies });
                var stringContent = new StringContent($"{{\"username\": \"{UserName}\", \"password\": \"{Password}\"}}", Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(query, stringContent);
                var responseCookies = cookies.GetCookies(new Uri(query)).Cast<Cookie>();

                return (response, responseCookies.First());
            }
            catch (Exception ex)
            {
                // Logginig
            }

            return (null, null);
        }
    }
}