using TodoIt.Data;
using TodoIt.Model;
using Xunit;

namespace TodoIt.Tests
{
    public class TodoItemsTests
    {


        // Testing AddNewTodo method, description needed ,todoId start from 1
        // and it will be generated vy  TodoSequencer.nextTodoId()
        [Theory]
        [InlineData("First task of Todo")]
        public void AddNewTodo_ShouldAdd_TaksTo_todoArray(string description)
        {
            TodoItems sut = new TodoItems();
            var callResult = sut.AddNewTodo(description);
            Assert.Equal(1, callResult.TodoId);
            Assert.Equal(description, callResult.Description);


        }

        // testing FindById method by adding a Todo object then get the todoId 
        //and check if its exist and if its equal the relevent data
        [Fact]
        public void FindById_ShouldReturn_Todo_WithSameId()
        {
            TodoItems sut = new TodoItems();
            var callResult = sut.AddNewTodo("Some tasks to do");
            var lastTodoId = callResult.TodoId;
            var personHasId = sut.FindById(lastTodoId);
            Assert.Equal(callResult.TodoId, personHasId.TodoId);
            Assert.Equal(callResult.Description, personHasId.Description);

        }

        // Testing FindAll by adding 2 todo and check if they are exist after calling the method
        [Fact]
        public void FindAll_ShouldReturn_AllTodoItems()
        {

            TodoItems sut = new TodoItems();
            sut.AddNewTodo("Task 1");
            sut.AddNewTodo("Task 2");
            var callResult = sut.FindAll();
            Assert.Equal("Task 1", callResult[0].Description);
            Assert.Equal("Task 2", callResult[1].Description);

        }

        // Testing Size method to get the size of the todo Array and check how many todo has ben added
        [Fact]
        public void Size_Should_Return_TodoArraySize()
        {
            TodoItems sut = new TodoItems();
            sut.AddNewTodo("task to test");
            sut.AddNewTodo("Another task to test");   // adding 2 todo tasks 
            Assert.Equal(2, sut.Size());
        }

        // Testing Clear method to clears all todo items from the Todo array and rest array size to 0.
        [Fact]
        public void Clear_Should_Empty_TodoArray()
        {
            TodoItems sut = new TodoItems();
            sut.AddNewTodo("Task no.1");
            sut.AddNewTodo("Task no,2");
            sut.Clear();
            Assert.Equal(0, sut.Size());
        }
        //10//
        // Testing FindByDoneStatus method by adding two tasks and change the done status to true for the first entry
        [Fact]
        public void FindByDoneStatus_Should_GetAllDoneTasks()
        {
            TodoItems sut = new TodoItems();
            sut.AddNewTodo("Task no.1").Done = true;
            sut.AddNewTodo("Task no,2"); // Done = false by defult
            var callResult = sut.FindByDoneStatus(false); // it should get the one that done = false "Task no.2" as default is false
            Assert.False(callResult[1].Done);
        }

        ///// Testing FindByAssignee method by personId

        [InlineData(1)]

        [Theory]
        public void FindByAssignee_ShouldGetAllAssignee_withGivenPesonID(int personId)
        { 
            People people = new People();
            TodoItems sut = new TodoItems();
            //add a person and assigne to a task
            var todo = sut.AddNewTodo("New task to do").Assignee = people.AddNewPerson("rami", "Sami");
            var callResult = sut.FindByAssignee(personId); // it should get the one that has personId = 1
            Assert.Equal(personId, callResult[0].Assignee.PersonId);
            Assert.Equal("rami", callResult[0].Assignee.FirstName);
        }

        ///// Testing FindByAssignee method Person assignee)

        [Fact]
        public void FindByAssignee_ShouldGetAllAssignee_withGivenAssignee()
        {
            People people = new People();
            var assignee = people.AddNewPerson("Harry", "Johan"); //add a person and assigne to a task
            TodoItems sut = new TodoItems();
            var todo = sut.AddNewTodo("New task to do").Assignee = assignee; // add assignee to the task
            var callResult = sut.FindByAssignee(assignee); // find by assignee
            Assert.Equal(assignee, callResult[0].Assignee);
            Assert.Equal(assignee.PersonId, callResult[0].Assignee.PersonId);
        }
        [Fact]
        public void FindUnassignedTodoItems_ShouldGetAll_UnassignedTodoItems()
        {

            TodoItems sut = new TodoItems();
             sut.AddNewTodo("New task to do");          // Adding new todoItems without assignee
            sut.AddNewTodo("Another new task to do"); 
            var callResult = sut.FindUnassignedTodoItems(); // find all 2 unassigned todo items
            Assert.Equal(2, callResult.Length);
            Assert.Equal("New task to do", callResult[0].Description);
            Assert.Equal("Another new task to do", callResult[1].Description);

        }
    }
}
