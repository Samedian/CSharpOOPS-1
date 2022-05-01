using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace APIAssignmentRepository
{
    public class CreateAccount
    {

        public int AccountNumber { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public double DailyTransactionLimit { get; set; }
    }
}
