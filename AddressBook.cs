using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookUsingCsvDay28
{
    public class AddressBook
    {
        public static void WriteCsv(List<Person> people, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(people);
            }
        }

        public static List<Person> ReadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader))
            {
                return csv.GetRecords<Person>().ToList();
            }
        }
    }

}