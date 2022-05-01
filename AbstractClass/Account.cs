using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class  Account
    {
         
        public int AccountNo { get; set; }

        public int DebitCardNo { get; set; }

        public int Pin { get; set; }

        public string AccountType { get; set; }

        public string LoginId { get; set; }

        public string Password { get; set; }

        public double Balance { get; set; }

        public abstract void CreateAccount();
        public abstract void DisplayAccount();
        
    }
}
