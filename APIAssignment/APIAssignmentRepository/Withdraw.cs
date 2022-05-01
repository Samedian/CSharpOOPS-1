using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace APIAssignmentRepository
{
    public class Withdraw
    {
        [Required]
        public int AccountNumber { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }
    }
}
