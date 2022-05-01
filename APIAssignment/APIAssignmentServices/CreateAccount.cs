using System;
using Entities;

namespace APIAssignmentServices
{
    public class CreateAccount
    {
        public void AddAccount(CreateAccountEntity account,CustomerDetailsEntity customer)
        {
            APIAssignmentRepository repository = new APIAssignmentRepository();
            repository.AddData(account, customer);
        }
    }
}
