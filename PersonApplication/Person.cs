using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
        public int Age { set; get; }
        public string PhoneNumber { set; get; }

        // constructor
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PersonMethod()
        {
            Console.WriteLine("Person does something...");
        }

        public override string ToString()
        {
            return "First name: " + FirstName + "Last name: " + LastName + "Address: " + Address + "Age: " + Age + "Phone number: " + PhoneNumber;
        }
    }
}
