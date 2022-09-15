namespace AddressBookUsingLinq
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("***************Welcome To AddressBook Using Linq*************");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            DataTable table = addressBookDataTable.createAddressBookTable();


            Contact contact = new Contact();
            Console.WriteLine("Enter the City ");
            contact.City = Console.ReadLine();
            addressBookDataTable.sortContactByGivenCity(contact);

            Console.Read();
        }
    }
}
