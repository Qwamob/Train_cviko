using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Person
    {

        private string lastName;
        private string firstName;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string? ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}