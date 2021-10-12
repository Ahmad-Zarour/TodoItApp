using System;
using TodoIt.Model;
using Xunit;

namespace TodoIt.Tests
{
    public class TodoTests
    {

        ///Testing the constructor of the class Todo by create an instance of it and check values 
        [Fact]
        public void Constructor_ShouldCreate_AnInstanceOf_TodoClass()
        {
            int todoId = 101;
            string description = "Descriptions about the task";
            Todo sut = new Todo(todoId, description);
            Assert.Equal(todoId, sut.TodoId);
            Assert.Equal(description, sut.Description);

        }
    }
}