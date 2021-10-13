using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class TodoSequencer
    {
        static int todoId;

        // Property to get the todoId value , for testing purpose
        public int TodoId { get { return todoId; } }

        // Method to increase todoId by one
        public static int nextTodoId()
        {
            return ++todoId;
        }

        //To reset the todoId to zero
        public static void reset()
        {
            todoId = 0;
        }
    }
}
