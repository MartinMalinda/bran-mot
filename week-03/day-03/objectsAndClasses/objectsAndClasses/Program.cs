using System;
using System.Collections.Generic;

namespace objectsAndClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Instantiate a Student and Teacher object
            //Call the student's Question() method and the teacher's Teach() method

            Student Jonny = new Student();
            Teacher Martha = new Teacher();

            Jonny.Question(Martha);
            Martha.Teach(Jonny);
        }
    }
}
