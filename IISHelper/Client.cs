using IISHelper.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace IISHelper
{
    public class Client 
    {   
        public string Username { get; private set; }
        public bool IsAuthorized { get; private set; } = false;

        private readonly HttpClient _HttpClient;
        private readonly CookieContainer _CookieContainer;
        private const string _BaseAddress = "https://iis.bsuir.by/api/v1/";

        public Client(string Username, string Password, bool LogIn = true)
        {
            _CookieContainer = new CookieContainer();
            _HttpClient = new HttpClient(new HttpClientHandler { CookieContainer = _CookieContainer })
            {
                BaseAddress = new Uri(_BaseAddress)
            };

            this.Username = Username;

            if (LogIn)
            {
                var authResult = TryAuth(Username, Password).Result;
                if (authResult.Item2 != null)
                {
                    _CookieContainer.Add(authResult.Item2);
                    IsAuthorized = true;
                }
            }
        }

        public async Task<PersonalCv> GetPersonalCv()
        {
            return await _HttpClient.GetFromJsonAsync<PersonalCv>("profiles/personal-cv");
        }

        public static async Task<(HttpResponseMessage, Cookie)> TryAuth(string Username, string Password)
        {
            var query = "https://iis.bsuir.by/api/v1/auth/login";

            try
            {
                var cookies = new CookieContainer();
                var httpClient = new HttpClient(new HttpClientHandler { CookieContainer = cookies });
                var stringContent = new StringContent($"{{\"username\": \"{Username}\", \"password\": \"{Password}\"}}", Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(query, stringContent);
                var responseCookies = cookies.GetCookies(new Uri(query)).Cast<Cookie>();

                return (response, responseCookies.First());
            }
            catch (Exception ex)
            {
                // Loggining
                throw;
            }

            return (null, null);
        }
    }
}