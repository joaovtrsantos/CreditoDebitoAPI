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
        public async Task UpdateCreditDebit([FromBody] UpdateCreditDebitRequest updateCreditDebitRequest, [FromServices] IUpdateCreditDebitUseCase updateCreditDebitUseCase)
        {
            await updateCreditDebitUseCase.Execute(updateCreditDebitRequest);
        }

        [HttpGet]
        public async Task<List<CreditDebit>> GetCreditDebits([FromServices] IGetCreditDebitsUseCase getCreditDebitsUseCase)
        {
            return await getCreditDebitsUseCase.Execute();
        }

        [HttpGet("by-id/{id}")]
        public async Task<CreditDebit> GetCreditDebit(Guid id, [FromServices] IGetCreditDebitByIdUseCase getCreditDebitByIdUseCase)
        {
            return await getCreditDebitByIdUseCase.Execute(id);
        }

        [HttpDelete("/{id}")]
        public async Task DeleteCreditDebit(Guid id, [FromServices] IDeleteCreditDebitUseCase deleteCreditDebitUseCase)
        {
            await deleteCreditDebitUseCase.Execute(id);
        }
    }
}
