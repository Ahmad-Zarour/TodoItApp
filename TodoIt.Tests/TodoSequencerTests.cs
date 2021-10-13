using System;
using TodoIt.Data;
using Xunit;

namespace TodoIt.Tests
{
    public class TodoSequencerTests
    {

        // Testing nextTodoId Method by calling it, save its results and check it with the expected values
        [Fact]
        public void nextTodoIdMethod_ShouldIncrese_todoId_ByOne()
        {                                                   //todoId = 0 as defult value
            int test1Result = TodoSequencer.nextTodoId();   //todoId = 1
            int test2Result = TodoSequencer.nextTodoId();   //todoId = 2
            int test3Result = TodoSequencer.nextTodoId();   //todoId = 3
            Assert.Equal(1, test1Result);
            Assert.Equal(2, test2Result);
            Assert.Equal(3, test3Result);
        }
        //Testing the reset method by calling nextTodoId to set a value in todoId then call the reset method
        //and then check result if its equal to zero
        [Fact]
        public void resetMethod_ShouldSet_personId_ToZero()
        {
            TodoSequencer sut = new TodoSequencer();
            TodoSequencer.nextTodoId();
            int testResult = TodoSequencer.nextTodoId();    //todoId = 2
            TodoSequencer.reset();
            Assert.Equal(0, sut.TodoId);
        }
    }
}
