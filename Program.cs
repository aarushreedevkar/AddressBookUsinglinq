namespace AddressBookUsingLinq
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("***************Welcome To AddressBook Using Linq*************");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            addressBookDataTable.createAddressBookTable();
            Console.Read();
        }
    }
}
    }
}
