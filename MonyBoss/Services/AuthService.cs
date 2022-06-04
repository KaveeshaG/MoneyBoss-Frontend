using MonyBoss.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MonyBoss.Services
{
    public class AuthService
    {
        private System.Net.Http.HttpClient client = new HttpClient();

        public AuthService()
        {
            this.client.BaseAddress = new Uri("http://localhost:5000/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client
                .DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<User> Register(User user)
        {
            var response = await client.PostAsJsonAsync("register", user);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<User>();
            }
            return null;
        }

        public async Task<User> Login(User user)
        {
            var response = await client.PostAsJsonAsync("login", user);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<User>();
            }
            return null;
        }
    }
}
