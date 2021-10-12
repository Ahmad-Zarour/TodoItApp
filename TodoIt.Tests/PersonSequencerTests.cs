using System;
using TodoIt.Data;
using Xunit;

namespace TodoIt.Tests
{
    public class PersonSequencerTests
    {
        [Fact]
        public void nextPersonIdMethod_ShouldIncrese_personId_ByOne()
        {
            int test1Result = PersonSequencer.nextPersonId();
            int test2Result = PersonSequencer.nextPersonId();
            int test3Result = PersonSequencer.nextPersonId();
            Assert.Equal(1, test1Result);
            Assert.Equal(2, test2Result);
            Assert.Equal(3, test3Result);
        }

        [Fact]
        public void resetMethod_ShouldSet_personId_ToZero()
        {
            PersonSequencer sut = new PersonSequencer();
            PersonSequencer.nextPersonId();
            PersonSequencer.nextPersonId();
            int testResult = PersonSequencer.nextPersonId();
            PersonSequencer.reset();
            Assert.Equal(0,sut.PersonId);
        }
    }
}
