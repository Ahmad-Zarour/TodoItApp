﻿using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;



namespace TodoIt.Data
{
    public class People
    {

        private static Person[] personArray = new Person[0];

        // Size method get the size of personArray and return 0 if its empty
        public int Size()
        {
            if(personArray.Length == 0)
            {
                Console.WriteLine("No person has been Added yet!!");
                return 0;
            } 
            else
            return personArray.Length;
        }

        // FindAll method, case of empty returns null or return an array of person
        public Person[] FindAll()
        {
            if (personArray.Length == 0)
            {
                Console.WriteLine("No person has been Added yet!!");
                return null;
            }
            else
            return personArray;
        }

        // FindById method , if person Id was found so method returns the relevant data else return null as not found
        public Person FindById(int personHasId)
        {
            if (personArray.Length < personHasId || personArray.Length > personHasId)
            { 
                Console.WriteLine($"Person with ID {personHasId} not exsist");
                return null;
            }
            else
            return personArray[personHasId-1];
        }

        // Add a new person to the personArray and return an object person
        public Person AddNewPerson(string firstName, string lastName)
        {
            Array.Resize<Person>(ref personArray, personArray.Length + 1); // expand the size of personArray by 1
            return personArray[personArray.Length-1] = new Person(PersonSequencer.nextPersonId(), firstName, lastName); 
        }

        // Clear all the content of personArray and reset the size to zero
        public void Clear()
        {
            Array.Clear(personArray, 0, personArray.Length);
            Array.Resize<Person>(ref personArray,0);
            Console.WriteLine("All Data has been cleared");
        }
    }
}