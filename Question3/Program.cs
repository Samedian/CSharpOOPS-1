using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactInfo contactInfo = null;

            ArrayList array = new ArrayList();

            char ch;
            do
            {
                contactInfo = ContactInfoMgr.StoreData(contactInfo);

                array.Add(contactInfo);

                ContactInfoMgr.ShowData(contactInfo);

                Console.WriteLine("Do you want to continue");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'Y' || ch == 'y');

            foreach (ContactInfo contact in array)
            {
                ContactInfoMgr.ShowData(contact);
            }

            Console.ReadKey();

        }
    }
}
