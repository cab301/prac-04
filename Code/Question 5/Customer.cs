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

        public Customer(string firstName, 
            string lastName, 
            string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        /// <summary>
        /// Determine if the current customer should come
        /// before, after, or has the same order as
        /// the other customer when sorting.
        /// </summary>
        /// <param name="other">The other customer</param>
        /// <returns>-1 if this customer comes before,
        /// 1 if this customer comes after,
        /// 0 if they have the same order</returns>
        public int CompareTo(Customer other)
        {
            string fullName = FirstName + " " + LastName;
            string otherFullName = other.FirstName + " " + other.LastName;
            return fullName.CompareTo(otherFullName);
        }

        public int CompareByNumber(Customer other)
        {
            return Number.CompareTo(other.Number);
        }
    }
}
