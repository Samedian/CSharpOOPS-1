using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class WithdrawEntity
    {
        public int AccountNumber { get; set; }

        public double Amount { get; set; }

        public DateTime TransactionDate { get; set; }

    }
}
