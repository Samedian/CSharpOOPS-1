using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Transaction
    {
        public Transaction(string TransactionId,double Amount,string Date)
        {
            this.TransactionId = TransactionId;
            this.Amount = Amount;
            this.Date = Date;
        }
        public string TransactionId { get; set; }

        public double Amount { get; set; }
        public string Date { get; set; }

    }
}
