using System;
using TodoIt.Data;
using Xunit;

namespace TodoIt.Tests
{
    public class PersonSequencerTests
    {
        // Testing nextPersonId Method by calling it, save its results and check it with the expected values
        [Fact]
        public void nextPersonIdMethod_ShouldIncrese_personId_ByOne()
        {
                                                                //personId = 0 as defult value
            int test1Result = PersonSequencer.nextPersonId();   //personId = 1
            int test2Result = PersonSequencer.nextPersonId();   //personId = 2
            int test3Result = PersonSequencer.nextPersonId();   //personId = 3
            Assert.Equal(1, test1Result);
            Assert.Equal(2, test2Result);
            Assert.Equal(3, test3Result);
        }

        //Testing the reset method by calling nextPersonId to set a value in personId then call the reset method
        //and then check result if its equal to zero
        [Fact]
        public void resetMethod_ShouldSet_personId_ToZero()
        {
            PersonSequencer sut = new PersonSequencer();
            PersonSequencer.nextPersonId();
            int testResult = PersonSequencer.nextPersonId(); // personId = 2 
            PersonSequencer.reset();
            Assert.Equal(0,sut.PersonId);
        }
    }
}
