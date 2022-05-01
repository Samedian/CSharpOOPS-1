using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIAssignmentRepository
{
    class AccountDBContext : DbContext 
    {
        public AccountDBContext(DbContextOptions<AccountDBContext> options) : base(options)
        {

        }
        
        public DbSet<CreateAccount> createAccount { get; set; }

        public DbSet<CustomerDetails> customerDetail { get; set; }

        public DbSet<Deposit> deposit { get; set; }

        public DbSet<Withdraw> withdraw { get; set; }

    }
}

