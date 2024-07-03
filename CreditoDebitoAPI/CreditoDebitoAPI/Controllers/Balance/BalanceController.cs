using Application.Response;
using Application.UseCases.Balance;
using Microsoft.AspNetCore.Mvc;

namespace CreditoDebitoAPI.Controllers.Balance
{
    [ApiController]
    [Route("[controller]")]
    public class BalanceController : Controller
    {
        [HttpGet("{days}")]
        public async Task<List<GetDailyBalanceResponse>> GetBalanceDaily(int days, [FromServices] IGetDailyBalanceUseCase getDailyBalanceUseCase)
        {
            return await getDailyBalanceUseCase.Execute(days);
        }
    }
}
