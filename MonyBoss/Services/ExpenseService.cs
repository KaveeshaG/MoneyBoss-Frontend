using MonyBoss.Models;

namespace MonyBoss.Services
{
    public class ExpenseService
    {
        private static HttpClient client = new HttpClient();

        public ExpenseService()
        {
            this.client.BaseAddress = new Uri("http://localhost:5000/expenses/");
            client.DefaultRequestHeaders.Accept.Clear();
            client
                .DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Expense> CreateExpense(Expense expense)
        {
            var response = await client.PostAsJsonAsync("", user);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Expense>();
            }

            return null;
        }

        public async void DeleteExpense(Guid userId, Guid expenseId) 
        {
            var response = await client.DeleteAsync($"{userId}/{expenseId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Expense>();
            }

            return null;
        }

        public async Task<Expense> GetExpense(Guid userId, Guid expenseId)
        {
            var response = await client.GetAsync($"{userId}/{expenseId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Expense>();
            }

            return null;
        }

        public async Task<IEnumerable<Expense>> GetExpenses(Guid userId)
        {
            var response = await client.GetAsync($"{userId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<IEnumerable<Expense>>();
            }

            return null;
        }
    }
}
