using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameronCoombs_Final_Project
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	namespace PersonGUI
	{
		class Person : MainWindow
		{
			private string address;
			private string email;
			private string firstName;
			private string lastName;
			public string Phone { get; set; }
			public int AddressID { get; set; }
			private static int count = 0;

			public Person()
			{
				count++;
				AddressID = count;
			}

			public Person(string first, string last, string add, string email, string phone)
			{
				count++;
				FirstName = first;
				LastName = last;
				Address = add;
				Email = email;
				Phone = phone;
			}
			public string LastName
			{
				get
				{
					return lastName;
				}
				set
				{
					lastName = value;
				}
			}

			public string FirstName
			{
				get
				{
					return firstName;
				}
				set
				{
					firstName = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set
				{
					address = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set
				{
					email = value;
				}
			}
		}

	}
}
