using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Data;

namespace TodoIt.Model
{
    public class Todo
    {
        // Fields , private by defult
        readonly int todoId;
        string description;
        bool done;
        Person assignee ;

        // Readonly property to get the TodoID
        public int TodoId
        {
            get { return todoId; }
        }
        public string Description
        {
            get { return description; }
            set {
                if (string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentNullException("Null or white space only not accepted for todo description");
                description = value; }
        }
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        public Person Assignee
        {
            get { return assignee; }
            set {
                if (value == null)
                {
                    throw new ArgumentException("No Assigned person, null or empty");
                }
                assignee = value;
            }
        }

        // Constructor to initiate the Todo object, takes todoId and description
        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            Description = description;
            this.done = false;        
        }
    }
}