namespace AddressBookUsingLinq
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("***************Welcome To AddressBook Using Linq*************");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            DataTable table = addressBookDataTable.createAddressBookTable();
            // addressBookDataTable.editContact(table);
            Contact contact = new Contact();

            Console.WriteLine("Enter the first name = ");
            contact.FirstName = Console.ReadLine();
            addressBookDataTable.deleteParticularContact(contact);

            Console.Read();
        }
    }
}
    

