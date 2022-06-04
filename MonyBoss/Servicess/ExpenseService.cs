using MoneyBoss.Models;

namespace MoneyBoss.Services
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

        public CreateExpense(Expense expense)
        {
            
        }
    }
}
