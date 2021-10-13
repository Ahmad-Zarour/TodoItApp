using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class PersonSequencer
    {
        static int personId;

        // Property to get the personId value , for testing purpose
        public int PersonId{ get { return personId; } }

        // Method to increase personId by one
        public static int nextPersonId()
        {
            return ++personId;
        }

        //To reset the personId to zero
        public static void reset()
        {
            personId = 0;
        }
    }
}