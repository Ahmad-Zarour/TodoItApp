using System;
using TodoIt.Model;
using Xunit;

namespace TodoIt.Tests
{
    public class PersonTests
    {

        // Prevent first and last name saving null or empty values so it will throw an ArgumentException
        [InlineData(100,"", "")]
        [InlineData(10,null, null)]
        [Theory]
        public void Person_FirstAndLastName_Entry_Check(int personId,string firstName, string lastName)
        {
            ArgumentException inputResult = Assert.Throws<ArgumentException>(
                () => new Person(personId,firstName, lastName));

            Assert.Equal("Null or Empty entry are not accepted!!", inputResult.Message);
        }

        ///Testing the constructor of the class Person by create an instance of it
        [Fact]
        public void Constructor_ShouldCreate_AnInstanceOf_PersonClass()
        {
            int personId = 101;
            string firstName = "PersonFirstName";
            string lastName = "PersonLastName";
            Person sut = new Person(personId,firstName, lastName);
            Assert.Equal(firstName, sut.FirstName);
            Assert.Equal(lastName, sut.LastName);

        }
    }
}
