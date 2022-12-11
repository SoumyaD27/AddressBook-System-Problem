using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UC4
{
        public class Person
        {
        private const string V = "firstName";
        public static List<Contacts> person = new List<Contacts>();

            public static void CreateContacts()
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

                person.Add(contacts);

            }


            public static void removeContact()
            {
                Console.WriteLine("Enter the First Name: ");
                string name = Console.ReadLine();

                foreach (var data in person)
                {
                    Console.WriteLine(person);
                }

                person.Remove(V);
            }
        }
    }