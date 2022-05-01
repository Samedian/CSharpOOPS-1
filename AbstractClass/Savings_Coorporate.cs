using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Savings_Coorporate
    {

     /*
        public string CompanyName { get; set; }

        public static void CreateSaving(Savings_Coorporate savings)
        {

            Console.WriteLine("Enter Company Name :");
            string companyName = Console.ReadLine();

            savings.CompanyName = companyName;
        }

        public static void DisplaySaving(Savings_Coorporate savings)
        {
            Console.WriteLine("Company Name :"+savings.CompanyName);

        }
        public override void CreateAccount(Account account)
        {
            int accountNo = 0, debitCardNo = 0;
            int pin;
            string accountType, loginId, password;
            double balance = 0;

            Console.WriteLine("Enter Account Number :");
            try
            {
                accountNo = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            account.AccountNo = accountNo;

            Console.WriteLine("Enter Account Type :");
            accountType = Console.ReadLine();

            accountType = char.ToUpper(accountType[0]) + accountType.Substring(1);

            if (!(accountType.Equals("Saving") || accountType.Equals("Loan") || accountType.Equals("Current")))
            {
                Console.WriteLine("Account Type should be Saving/Current/Loan");

            }

            account.AccountType = accountType;

            Console.WriteLine("Enter Login Id :");
            loginId = Console.ReadLine();

            account.LoginId = loginId;
            Console.WriteLine("Enter Password :");
            password = Console.ReadLine();

            account.Password = password;

            Console.WriteLine("Enter Debit card no :");
            try
            {
                debitCardNo = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }


            account.DebitCardNo = debitCardNo;
            Console.WriteLine("Enter Pin :");
            pin = Convert.ToInt32(Console.ReadLine());

            account.Pin = pin;
            Console.WriteLine("Enter Balance");

            try
            {
                balance = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            account.Balance = balance;


        }
        public override void DisplayAccount(Account account)
        {
            Console.WriteLine("Account Number  :" + account.AccountNo);
            Console.WriteLine("Account Type    :" + account.AccountType);
            Console.WriteLine("Debit Card No   :" + account.DebitCardNo);
            Console.WriteLine("Pin             :" + account.Pin);
            Console.WriteLine("Login Id        :" + account.LoginId);
            Console.WriteLine("Password        :" + account.Password);
        }

        */
    }
}
