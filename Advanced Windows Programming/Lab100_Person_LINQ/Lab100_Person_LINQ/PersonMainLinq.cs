using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_Person_LINQ
{
    class PersonMainLinq
    {
        static void Main(string[] args)
        {
            DataList arr;
            string datafile = @"Z:\IT\IST215\Yusuf\Lab Assignments\Person2000Address.csv";

            arr = new DataList(datafile);
            arr.LoadData();

            Console.WriteLine("\n1. Display All people");

            String searchKey = "Davis";
            Console.WriteLine($"\n2. Find person by lastname, name = '{searchKey}'");
            Person personFound = arr.FindPerson(searchKey);

            string msg = personFound != null ? $" Found {personFound}\n" : $"NOT Found {searchKey}\n";
            Console.WriteLine(msg);

            Console.WriteLine("\n3.1. Find person by Person object ");
            Person temp = new Person("Michael", "Williams", "69 Andrews Dr", "Aberdeen", "SD", 06031);
            personFound = arr.FindPerson(temp);
            msg = personFound != null ? $" Found {personFound}\n" : $"NOT Found {temp}\n";
            Console.WriteLine(msg);

            Console.WriteLine("\n3.2. Find person by Person object (person is not in the list)");
            temp = new Person("Monica", "Williams", "69 Andrews Dr", "Aberdeen", "SD", 06031);
            personFound = arr.FindPerson(temp);
            msg = personFound != null ? $" Found {personFound}\n" : $"NOT Found {temp}\n";
            Console.WriteLine(msg);

            Console.WriteLine("\n4.1. Display people from Albany");
            arr.DisplayPeopleByCity("Albany");

            Console.WriteLine("\n4.2. Display people from Albany, NY");
            arr.DisplayPeopleByCityAndState("Albany", "NY");

            string findLastName = "Levy";
            Console.WriteLine($"\n5 Display people with lastName '{findLastName}', NY");
            arr.FindPeopleWithSameLastName(findLastName).ForEach(n => Console.WriteLine(n));

            Console.WriteLine("\n6 Compare a few people by last name");
            Console.WriteLine("\t" + arr.CompareTwoPersons(arr.GetPersonAt(3), arr.GetPersonAt(33)));
            Console.WriteLine("\t" + arr.CompareTwoPersons(arr.GetPersonAt(1000), arr.GetPersonAt(100)));
            Console.WriteLine("\t" + arr.CompareTwoPersons(arr.GetPersonAt(1500), arr.GetPersonAt(150)));

            Console.WriteLine($"\n7 Find a person's address. ");
            Console.WriteLine($"\t{arr.GetPersonAt(4).FirstName} {arr.GetPersonAt(4).LastName}");
            Console.WriteLine("\t" + arr.FindPersonAddress(arr.GetPersonAt(4)));

        } // end method
    } // end class 
} // end namespace
