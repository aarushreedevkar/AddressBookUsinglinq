namespace AddressBookUsingLinq
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("***************Welcome To AddressBook Using Linq*************");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            System.Data.DataTable table = addressBookDataTable.createAddressBookTable();
            addressBookDataTable.editContact(table);

            Console.Read();
        }
    }
}
    

