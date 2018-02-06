using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_Person_LINQ
{
    class DataList
    {
        private List<Person> personList;
        public string FileName { get; set; }
        public DataList(string fname)
        {
            FileName = fname;
            personList = new List<Person>();
        }

        public Person FindPerson(String lastName)
        {
            var person = from p in personList
                         where p.LastName == lastName
                         select p;
            return person.FirstOrDefault();
        } // end Find

        public Person GetPersonAt(int i) { return personList.ElementAt(i); }

        public Person FindPerson(Person otherPerson)
        {
            var per =
                from p in personList
                where p.Equals(otherPerson)
                select p;
            return per.FirstOrDefault();
        } // end FindPerson

        public string FindPersonAddress(Person otherPerson)
        {
            string addr = null;
            var persons =
                from p in personList
                where p.Equals(otherPerson)
                select p;

            Person p1 = persons.FirstOrDefault();
            if (p1 != null)
            {
                addr = string.Format($"{p1.FirstName}'s address is: " +
                    $"{p1.Address} {p1.City} {p1.State} {p1.Zip}");
            }
            return addr;
        } // emd find 

        public List<Person> FindPeopleWithSameLastName(string lastName)
        {
            var per =
                (from p in personList
                 where p.LastName.Equals(lastName)
                 select p).ToList();
            return per;
        } // end FindPeopleWithSameLastName

        public void InsertPerson(String first, String last, String addr, String city,
            String state, int zp)
        {
            personList.Add(new Person(first, last, addr, city, state, zp));
            return;
        }

        public void DisplayPeopleByCity(string c)
        {
            var byCity = from p in personList
                         where p.City == c
                         select p;
            byCity.ToList<Person>().ForEach(x => Console.WriteLine(x));
            return;
        }

        public void DisplayPeopleByCityAndState(string c, string st)
        {
            var byCity = from p in personList
                         where (p.City == c && p.State == st)
                         select p;
            byCity.ToList<Person>().ForEach(x => Console.WriteLine(x));
            return;
        }

        public bool DeletePerson(Person thisPerson) => personList.Remove(thisPerson);

        public void DisplayPeople()
        {
            int i = 0;
            personList.ForEach(x => Console.WriteLine($"{++i,6}) {x}"));
            Console.WriteLine();
        }

        public int LoadData()
        {
            string line;
            string[] words;
            int NumOfRecords = 0;

            StreamReader reader = new StreamReader(FileName);
            try
            {
                do
                {
                    NumOfRecords++;
                    line = reader.ReadLine();
                    words = line.Split(new string[] { "," },
                        StringSplitOptions.RemoveEmptyEntries);
                    personList.Add(new Person(words[0], words[1], words[2], words[3],
                        words[4], Convert.ToInt32(words[5])));
                } while (reader.Peek() != -1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
            }
                Console.WriteLine($"Loading records, number of records read: {NumOfRecords}");
                return NumOfRecords;
        } // end LoadData

        public string CompareTwoPersons(Person p1, Person p2)
        {
            int compare = p1.CompareTo(p2);
            string retValue = "";
            switch (compare)
            {
                case -1:
                    retValue = $"{p1.FirstName} {p1.LastName} is less than to {p2.FirstName} {p2.LastName}";
                    break;
                case 0:
                    retValue = $"{p1.FirstName} {p1.LastName} is equal to {p2.FirstName} {p2.LastName}";
                    break;
                case 1:
                    retValue = $"{p1.FirstName} {p1.LastName} is greater than {p2.FirstName} {p2.LastName}";
                    break;
                default:
                    Console.WriteLine("This cannot happen, fix your code...");
                    retValue = $"{p1.FirstName} {p1.LastName} is less than to {p2.FirstName} {p2.LastName}";
                    break;
            }
            return retValue;
        } // end CompareTwoPersons
      } // end class 
    } // end namespace

