namespace Application.Response
{
    public class GetDailyBalanceResponse(DateOnly date, decimal balance)
    {
        public DateOnly Date { get; set; } = date;
        public decimal Balance { get; set; } = balance;
    }
}
