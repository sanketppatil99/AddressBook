using System;
namespace AddressBookSystem
{
    class Program
    {
        public static List<Contacts> Person = new List<Contacts>();

        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");

            AddressBookSystem.AddressBook.CreateContacts();


            bool end = true;
            while (true)
            {
                Console.WriteLine("Select Option\n1.add Contact \n2.Display \n3.Edit Contact \n4.end");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBook.CreateContacts();
                        break;
                    case 2:
                        AddressBook.Dispaly();
                        break;
                    case 3:
                        
                       AddressBook.EditContact();
                        break;
                    case 4:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect Option");
                        break;
                }
            }
        }
    }
}
