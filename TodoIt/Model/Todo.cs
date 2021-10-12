using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Todo
    {
        // Fields , private by defult
        readonly int _todoId;
        string _description;
        bool _done;
        Person _assignee;



        // Readonly property to get the TodoID
        public int TodoId
        {
            get { return _todoId; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public bool Done
        {
            get { return _done; }
            set { _done = value; }
        }
        public Person Assignee
        {
            get { return _assignee; }
            set { _assignee = value; }
        }

        // Constructor to initiate the Todo object, takes todoId and description
        public Todo(int todoId, string description)
        {
            _todoId = todoId;
            Description = description;
        }
    }
}