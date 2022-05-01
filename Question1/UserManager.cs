using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class UserManager
    {
        public class NegativeNumber : Exception
        {
            public NegativeNumber(String msg)
                : base(msg)
            {

            }
        }


        public class NameContainDigit : Exception
        {
            public NameContainDigit(String msg)
                : base(msg)
            {

            }
        }

        public class Gender : Exception
        {
            public Gender(String msg)
                : base(msg)
            {
            }

        }

        public class DateException : Exception
        {

            public DateException(String msg)
                : base(msg)
            {
            }
        }
        public static User AddUser(User user)
        {

            string dob, userName, guardianName;
            int userId = 0;
            char gender;
            Console.WriteLine("Enter UserId");

            try
            {
                userId = Convert.ToInt32(Console.ReadLine());
                if (userId <= 0)
                    throw new NegativeNumber("Sorry ,User Id can't be negative ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            Console.WriteLine("Enter User Name ");
            userName = Console.ReadLine();

            try
            {
                userName = ConverName(userName);
                if (userName == null)
                    throw new NameContainDigit("Sorry ,Your Name contain digits ");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            Console.WriteLine("Enter Guardian Name");
            guardianName = Console.ReadLine();

            try
            {
                guardianName = ConverName(guardianName);
                if (guardianName == null)
                    throw new NameContainDigit("Sorry ,Your Name contain digits ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }



            Console.WriteLine("Enter Character :");
            gender = Convert.ToChar(Console.ReadLine());

            try
            {

                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                gender = textInfo.ToUpper(gender);

                if (!(gender == 'M' || gender == 'F'))
                    throw new Gender("Sorry ,Gender not match");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }


            Console.WriteLine("Enter date of birth ");
            dob = Console.ReadLine();

            user = new User(userId, dob, userName, gender, guardianName);

            return user;
        }

        private static string ConverName(string userName)
        {

            if (userName.Any(char.IsDigit))
                return null;

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            userName = textInfo.ToTitleCase(userName);

            return userName;

        }

        static void Main(string[] args)
        {
            char ch;
            do
            {
                User user = null;
                user = AddUser(user);

                showdata(user);

                Console.WriteLine("Do you want to continue :");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'Y' || ch == 'y');

            Console.ReadKey();
        }

        private static void showdata(User user)
        {
            Console.WriteLine("User Id   :" + user.UserName);
            Console.WriteLine("User Name :" + user.UserName);
            Console.WriteLine("Dob       :" + user.DOB);
            Console.WriteLine("Gender    :" + user.Gender);
            Console.WriteLine("Guardian  :" + user.GuardianName);
        }

    }
}
