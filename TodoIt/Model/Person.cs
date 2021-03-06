using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Person
    {
        // Fields , private by defult
        readonly int personId;
        string firstName;
        string lastName;

        // Properties 
        public int PersonId { get { return personId; } }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                // If the argument is null or empty string so the program will throw an ArgumentException.
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Null or Empty entry for firstname are not accepted!!");
                else
                    firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                // If the argument is null or empty string so the program will throw an ArgumentException.
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Null or Empty entry values for lastname are not accepted!!");
                else
                    lastName = value;
            }
        }

        // Constructors to initiate the person object
        public Person(int personId,string firstName, string lastName)
        {
            this.personId = personId;
            FirstName = firstName;
            LastName = lastName;   
        }
    }
}