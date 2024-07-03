using Application.Requests;
using Application.UseCases.CreditDebits;
using Microsoft.AspNetCore.Mvc;

namespace CreditoDebitoAPI.Controllers.CreditDebits
{
    [ApiController]
    [Route("[controller]")]
    public class CreditDebitController : Controller
    {
        [HttpPost]
        public async Task CreateCreditDebit([FromBody] CreateCreditDebitRequest createCreditDebitRequest, [FromServices] ICreateCreditDebitUseCase createCreditDebitUseCase)
        {
            await createCreditDebitUseCase.Execute(createCreditDebitRequest);
        }
    }
}
