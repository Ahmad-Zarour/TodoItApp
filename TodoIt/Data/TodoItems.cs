﻿using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;


namespace TodoIt.Data
{
    public class TodoItems
    {
        private static Todo[] todoArray = new Todo[0];

        // Size method get the size of todoArray and return 0 if its empty
        public int Size()
        {
            if (todoArray.Length == 0)
            {
                Console.WriteLine("No todo tasks has been Added yet!!");
                return 0;
            }
            else
                return todoArray.Length;
        }

        // FindAll method, case of empty returns null or return an array of todo object
        public Todo[] FindAll()
        {
            if (todoArray.Length == 0)
            {
                Console.WriteLine("No todo tasks has been Added yet!!");
                return null;
            }
            else
                return todoArray;
        }

        // FindById method , if todo Id was found so method returns the relevant data else return null as not found
        public Todo FindById(int todoHasId)
        {
            if (todoArray.Length < todoHasId || todoArray.Length > todoHasId)
            {
                Console.WriteLine($"Todo taks with ID {todoHasId} not exsist");
                return null;
            }
            else
                return todoArray[todoHasId - 1];
        }

        // Add a new todo to the todoArray and return an object todo , todoId will be generated by TodoSequencer.nextTodoId()
        public Todo AddNewTodo(string description)
        {
            Array.Resize<Todo>(ref todoArray, todoArray.Length + 1); // expand the size of todoArray by 1
            return todoArray[^1] = new Todo(TodoSequencer.nextTodoId(), description);
        }

        // Clear all the content of todoArray and reset the size to zero
        public void Clear()
        {
            Array.Clear(todoArray, 0, todoArray.Length);
            Array.Resize<Todo>(ref todoArray, 0);
            Console.WriteLine("All Data has been cleared");
        }
    }
}
