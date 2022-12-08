using System;
namespace UC2
{
    public class Program
    {
        public static List<Contacts> Person = new List<Contacts>();
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Address Book");
            UC2.Person.CreateContacts();
        }
    }
}