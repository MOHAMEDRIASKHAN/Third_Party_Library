namespace AddressBookUsingCsvDay28
{
    class program
    {
        public static void Main(String[] args)
        {
            var people = new List<Person>
        {
             new Person { Name = "Riyas", Email = "Riyas@example.com", PhoneNumber = "1234567890" },
             new Person { Name = "Prince", Email = "Prince@example.com", PhoneNumber = "9876543210" }
        };

            var filePath = "address_book.csv";
            AddressBook.WriteCsv(people, filePath);
            var peopleFromFile = AddressBook.ReadCsv(filePath);
        }
    }
}