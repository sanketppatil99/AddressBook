using AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static void CreateContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name : ");
            contacts.fName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contacts.lName = Console.ReadLine();

            Console.WriteLine("Enter address : ");
            contacts.address = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            contacts.city = Console.ReadLine();

            Console.WriteLine("Enter State : ");
            contacts.state = Console.ReadLine();

            Console.WriteLine("Enter ZipCode : ");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number : ");
            contacts.phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            contacts.email = Console.ReadLine();
            Program.Person.Add(contacts);

        }
    }
}
