using MonyBoss.Models;

namespace MonyBoss.Services
{
    public class IncomeService
    {
        private static HttpClient client = new HttpClient();

        public IncomeService()
        {
            this.client.BaseAddress = new Uri("http://localhost:5000/incomes/");
            client.DefaultRequestHeaders.Accept.Clear();
            client
                .DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Income> CreateIncome(Income income)
        {
            var response = await client.PostAsJsonAsync("", income);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Income>();
            }

            return null;
        }

        public async void DeleteIncome(Guid userId, Guid incomeId)
        {
            var response = await client.DeleteAsync($"{userId}/{incomeId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Income>();
            }

            return null;
        }

        public async Task<Income> GetIncome(Guid userId, Guid incomeId)
        {
            var response = await client.GetAsync($"{userId}/{incomeId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Income>();
            }

            return null;
        }

        public async Task<IEnumerable<Income>> GetIncomes(Guid userId)
        {
            var response = await client.GetAsync($"{userId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<IEnumerable<Income>>();
            }

            return null;
        }
    }
}
