using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Todo
    {
        // Fields , private by defult
        readonly int todoId;
        string description;
        bool done;
        Person assignee;



        // Readonly property to get the TodoID
        public int TodoId
        {
            get { return todoId; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }

        // Constructor to initiate the Todo object, takes todoId and description
        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            Description = description;
        }
    }
}