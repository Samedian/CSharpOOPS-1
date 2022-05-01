using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {

        public static void Main(string[] args)
        {
            Current current = new Current();
            current.CreateAccount();
            current.DisplayAccount();

            Console.ReadKey();
        }
        
        

    }
}
