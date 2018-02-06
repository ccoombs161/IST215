using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_Person_LINQ
{
    class Person : IComparable<Person>, IEquatable<Person>
    {
       // Public properties
       public String LastName { get; set; }
       public String FirstName { get; set; }
       public String Address { get; set; }
       public String City { get; set; }
       public String State { get; set; }
       public int Zip { get; set; }
       
       // Constructor 
       public Person(String first, String last, String addr, String city, String state,
           int zp)
        {
            FirstName = first;
            LastName = last;
            Address = addr;
            City = city;
            State = state;
            Zip = zp;
        } // Constructor 

        // no-arg constructor
        public Person()
            : this(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0)
        {
        } // no-arg constructor
    
        public bool Equals(Person other)
        {
            if (other == null) return false;

            // same object, comparing itself
            if (this == other) return true;

            // if other object is null or it's type isnt same as this
            if (other == null || this.GetType() != other.GetType()) return false;

            if (this.FirstName == null && other.FirstName != null)
            {
                return false;
            }
            else if (!FirstName.Equals(other.FirstName))
                return false;
            if (this.LastName == null && other.LastName != null)
            {
                return false;
            }
            else if (!LastName.Equals(other.LastName))
                return false;
            return true;
        } // Equals

        public int CompareTo(Person other)
        {
            if (this.LastName.Equals(other.LastName))
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            return this.LastName.CompareTo(other.LastName);
        } // CompareTo

        public override string ToString() =>
        string.Format("{0,12} {1,-12} {2, -30} {3, -24} {4, -6} {5:d5}",
            FirstName, LastName, Address, City, State, Zip);
    }
}
