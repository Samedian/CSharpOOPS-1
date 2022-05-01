using System;

namespace AbstractClass
{
    class Current : Account
    {
        public string CompanyName { get; set; }
        public string TypeOfBussiness { get; set; }
        public string Website { get; set; }
        public string ContactName { get; set; }

        public override void CreateAccount()
        {
            int accountNo = 0;
            int debitCardNo = 0;
            int pin;
            string accountType;
            string loginId;
            string password;
            double balance = 0.0;

            Console.WriteLine("Enter Account Number :");
            try
            {
                accountNo = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            AccountNo = accountNo;

            Console.WriteLine("Enter Debit card no :");
            try
            {
                debitCardNo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            DebitCardNo = debitCardNo;
            
            Console.WriteLine("Enter Pin :");
            pin = Convert.ToInt32(Console.ReadLine());
            Pin = pin;

            Console.WriteLine("Enter Account Type :");
            accountType = Console.ReadLine();
            accountType = char.ToUpper(accountType[0]) + accountType.Substring(1);
            if (!(accountType.Equals("Saving") || accountType.Equals("Loan") || accountType.Equals("Current")))
            {
                Console.WriteLine("Account Type should be Saving/Current/Loan");   
            }
            AccountType = accountType;

            Console.WriteLine("Enter Login Id :");
            loginId = Console.ReadLine();
            LoginId = loginId;

            Console.WriteLine("Enter Password :");
            password = Console.ReadLine();
            Password = password;

            Console.WriteLine("Enter Balance");
            try
            {
                balance = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Balance = balance;

            Console.WriteLine("Enter Company Name :");
            this.CompanyName = Console.ReadLine();
            
            Console.WriteLine("Enter type of Bussiness :");
            this.TypeOfBussiness = Console.ReadLine();

            Console.WriteLine("Enter Website :");
            this.Website = Console.ReadLine();
            
            Console.WriteLine("Enter Contact Name :");
            this.ContactName = Console.ReadLine();

        }

        public override void DisplayAccount()
        {
            Console.WriteLine("Account Number  :" + AccountNo);
            Console.WriteLine("Debit Card No   :" + DebitCardNo);
            Console.WriteLine("Pin             :" + Pin);
            Console.WriteLine("Account Type    :" + AccountType);
            Console.WriteLine("Login Id        :" + LoginId);
            Console.WriteLine("Password        :" + Password);
            Console.WriteLine("Balance         :" + Balance);
            Console.WriteLine("Company Name    :" + CompanyName);
            Console.WriteLine("Type            :" + TypeOfBussiness);
            Console.WriteLine("Website         :" + Website);
            Console.WriteLine("Contact Name    :" + ContactName);

        }

    }
}
