using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Intefaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
       void Transfer(AccountTransfer accountTransfer);
    }
}
