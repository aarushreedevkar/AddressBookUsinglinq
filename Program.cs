namespace AddressBookUsingLinq
{
    class program
    {
        public static void Main(String[] args)
        {
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            addressBookDataTable.createAddressBookTable();
            Console.Read();
        }
    }
}
