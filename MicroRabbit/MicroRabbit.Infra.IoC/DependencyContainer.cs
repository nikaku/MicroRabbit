using MicroRabbit.Banking.Application.Intefaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using MiroRabbit.Banking.Data.Context;
using MiroRabbit.Banking.Data.Repositries;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Services
            services.AddTransient<IAccountService, AccountService>();

            //Repositories
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingContext>();
        }
    }
}
