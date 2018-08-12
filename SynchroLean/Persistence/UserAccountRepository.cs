﻿using Microsoft.EntityFrameworkCore;
using SynchroLean.Core;
using SynchroLean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynchroLean.Persistence
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly SynchroLeanDbContext context;

        public UserAccountRepository(SynchroLeanDbContext context)
        {
            this.context = context;
        }

        public async Task<UserAccount> GetUserAccountAsync(string emailAddress)
        {
            return await context.UserAccounts
                .FindAsync(emailAddress.Trim().ToLower());
        }

        public async Task AddAsync(UserAccount account)
        {
            await context.UserAccounts.AddAsync(account);
        }

        public async Task<Boolean> UserAccountExists(string emailAddress)
        {
            return await context.UserAccounts
                .AnyAsync(user => user.Email == emailAddress);
        }

        public async Task Clean()
        {
            var startOfLastYear = new DateTime(DateTime.Now.Year, 1, 1);
            var accountsToDelete = await
                (from account in context.UserAccounts
                 where account.IsDeleted && account.Deleted < startOfLastYear
                 select account).ToListAsync();
            foreach (var accountToDelete in accountsToDelete) context.UserAccounts.Remove(accountToDelete);
        }
    }
}
