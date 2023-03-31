using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Customer
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Number { get; }

        public Customer(string firstName, string lastName, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public override string? ToString()
        {
            return string.Format("{0} \t\t {1} \t\t {2}",
                FirstName, LastName, Number);
        }

        /// <summary>
        /// Return a negative number if this customer should come
        /// before the other customer, a positive number if
        /// this customer should come after the other customer,
        /// or 0 if they are in the same sorting order.
        /// </summary>
        /// <param name="other">The other customer</param>
        /// <returns>Return a negative number if this customer should come
        /// before the other customer, a positive number if
        /// this customer should come after the other customer,
        /// or 0 if they are in the same sorting order.</returns>
        public int CompareByFullName(Customer other)
        {
            string fullName = FirstName + " " + LastName;
            string otherFullName = other.FirstName + " " + other.LastName;
            return fullName.CompareTo(otherFullName);
        }

        public int CompareByNumber(Customer other)
        {
            return long.Parse(Number)
                .CompareTo(long.Parse(other.Number));
        }
    }
}
