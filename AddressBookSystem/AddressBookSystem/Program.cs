namespace AddressBookSystem
{
    class Program
    {
        public static List<Contacts> Person = new List<Contacts>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");

            AddressBookSystem.AddressBook.CreateContacts();
        }
    }
}
