using System;
using TodoIt.Data;
using TodoIt.Model;
using Xunit;

namespace TodoIt.Tests
{
    public class PeopleTests
    {


        // Testing AddNewPerson method , consume that we start from person id = 1
        [Theory]
        [InlineData("Kylian", "Mbappe")]        
        public void AddNewPerson_Should_CreateAPerson_ToPersonArray(string firstName, string lastName)
        {
            People sut = new People();
            var callResult = sut.AddNewPerson(firstName, lastName);
            Assert.Equal(1,callResult.PersonId);
            Assert.Equal(firstName, callResult.FirstName);
            Assert.Equal(lastName, callResult.LastName);
          
        }

        // testing FindById method by adding a person then get the id and check if its exist and if its equal the relevent data
        [Fact]
        public void FindById_ShouldReturn_Person_WithSameId()
        {
            People sut = new People();
            var callResult = sut.AddNewPerson("Harry", "Kane");
            var lastTodoId = callResult.PersonId;
            var personHasId = sut.FindById(lastTodoId);
            Assert.Equal(callResult.PersonId, personHasId.PersonId);
            Assert.Equal(callResult.FirstName, personHasId.FirstName);
            Assert.Equal(callResult.LastName, personHasId.LastName);
            
        }

        // Testing FindAll by adding 2 person and check if they are exist after calling the method
        [Fact]
        public void FindAll_ShouldReturn_AllPerson()
        {

            People sut = new People();
            sut.AddNewPerson("Ida","Andersson");
            sut.AddNewPerson("Rima","Sevensson");
            var callResult = sut.FindAll();
            Assert.Equal("Ida",callResult[0].FirstName);
            Assert.Equal("Andersson", callResult[0].LastName);
            Assert.Equal("Rima", callResult[1].FirstName);
            Assert.Equal("Sevensson", callResult[1].LastName);
        }

        // Testing Size method to get the size of the person Array and check how many person has ben added
        [Fact]
        public void Size_Should_Return_PersonArraySize()
        {
            People sut = new People();
            sut.AddNewPerson("First1", "Last1");
            sut.AddNewPerson("First2", "Last2");   // adding 2 person 
            Assert.Equal(2,sut.Size());
        }

        // Testing Clear method to clears all Person objects from the Person array ans array síze reset to 0.
        [Fact]
        public void Clear_Should_Empty_PersonArray()
        {
            People sut = new People();
            sut.AddNewPerson("Anna", "Sara");
            sut.AddNewPerson("Person", "num2");
            sut.Clear();
            Assert.Equal(0, sut.Size());
        }

        // Testing RemovePerson method
        [Fact]
        public void RemovePerson_Should_TerminatePerson()
        {
            People sut = new People();
            var person = sut.AddNewPerson("NewPerson", "LastName");
            Assert.True(sut.RemovePerson(person));
            // now no person in personArry so method return false
            Assert.False(sut.RemovePerson(person));
        }
    }
}
