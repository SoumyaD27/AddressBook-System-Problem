using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3
{
    public class Person
    {
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
       
    
        public static void editContact()
        {
            Console.WriteLine("Enter the First Name: ");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.firstName == name)
                    {
                        
                       Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.City\n 4.State\n 5.Zipcode\n 6.PhoneNumber\n 7.EmailID\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch(option)
                        {
                            case 1:
                                string firstName = Console.ReadLine();
                                data.firstName = firstName;
                                break;
                            case 2:
                                string lastName = Console.ReadLine();
                                data.lastName = lastName;
                                break;
                            case 3:
                                string city = Console.ReadLine();
                                data.city = city;
                                break;
                            case 4:
                                string state = Console.ReadLine();
                                data.state = state;
                                break;
                            case 5:
                                string zipCode = Console.ReadLine();
                                data.zipCode = zipCode;
                                break;
                            case 6:
                                string phoneNumber = Console.ReadLine();
                                data.phoneNumber = phoneNumber;
                                break;
                            case 7:
                                string emailID = Console.ReadLine();
                                data.emailID = emailID;
                                break;
                            default:
                                Console.WriteLine("Chose valid option");
                                break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Name doesnot match.");
                    }
                } 
            }
        }

    }
}
