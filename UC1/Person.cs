using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1
{
    public class Person
    {
        public static void CreateContracts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name: ");
            contacts.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            contacts.lastName = Console.ReadLine();
            Console.WriteLine("Enter City Name: ");
            contacts.city = Console.ReadLine();
            Console.WriteLine("Enter State Name: ");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter zip Code: ");
            contacts.zipCode = Console.ReadLine();
            Console.WriteLine("Enter Phone Number: ");
            contacts.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email ID: ");
            contacts.emailID = Console.ReadLine();
        }
    }
}
