using Application.UseCases.CreditDebits;
using Domain.Interfaces;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationModule
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddScoped<ICreditDebitRepository, CreditDebitRepository>();

            services.AddScoped<ICreateCreditDebitUseCase, CreateCreditDebitUseCase>();
            services.AddScoped<IGetCreditDebitsUseCase, GetCreditDebitsUseCase>();

        }
    }
}
