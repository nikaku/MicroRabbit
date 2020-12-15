using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MiroRabbit.Banking.Data.Context;
using System;
using System.Collections.Generic;

namespace MiroRabbit.Banking.Data.Repositries
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingContext _context;

        public AccountRepository(BankingContext context)
        {
            _context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
