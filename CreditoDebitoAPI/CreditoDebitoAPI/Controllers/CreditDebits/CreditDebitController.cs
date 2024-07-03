using Application.Requests;
using Application.UseCases.CreditDebits;
using Domain.Entities;
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

        [HttpPut]
        public async Task UpdateCreditDebit([FromBody] CreateCreditDebitRequest createCreditDebitRequest, [FromServices] ICreateCreditDebitUseCase createCreditDebitUseCase)
        {
            await createCreditDebitUseCase.Execute(createCreditDebitRequest);
        }

        [HttpGet]
        public async Task<List<CreditDebit>> GetCreditDebits([FromServices] IGetCreditDebitsUseCase getCreditDebitsUseCase)
        {
            return await getCreditDebitsUseCase.Execute();
        }

        [HttpGet("by-id")]
        public async Task GetCreditDebit([FromBody] CreateCreditDebitRequest createCreditDebitRequest, [FromServices] ICreateCreditDebitUseCase createCreditDebitUseCase)
        {
            await createCreditDebitUseCase.Execute(createCreditDebitRequest);
        }

        [HttpDelete]
        public async Task DeleteCreditDebit([FromBody] CreateCreditDebitRequest createCreditDebitRequest, [FromServices] ICreateCreditDebitUseCase createCreditDebitUseCase)
        {
            await createCreditDebitUseCase.Execute(createCreditDebitRequest);
        }
    }
}
