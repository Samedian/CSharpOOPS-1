using System;
using System.Collections.Generic;
using System.Text;

namespace APIAssignmentRepository
{
    public class AddAccountDetails
    {
        public void AddData(CreateAccountEntity accountEntity,CustomerDetailsEntity customer)
        {
            using(var context = new AccountDBContext())
            {
                var account = new CreateAccount
                {
                    CustomerName = accountEntity.CustomerName,
                    DailyTransactionLimit = accountEntity.DailyTransactionLimit;

                };
                context.createAccount.Add(account);
                context.SaveChanges();
            }

            using(var context = new AccountDBContext())
            {

            }
    }
}
