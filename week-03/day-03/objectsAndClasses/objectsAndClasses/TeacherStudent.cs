using System;
namespace objectsAndClasses
{
    //Create Student and Teacher classes
    //Student
    //Learn() -> prints the student is learning something new
    //Question(teacher) -> calls the teachers answer method
    //Teacher
    //Teach(student) -> calls the students learn method
    //Answer() -> prints the teacher is answering a question
    
    public class Student
    {
        public Student()
        {
        }
        public void Learn()
        {
            Console.WriteLine("The student is learning something new");
        }
        public void Question(Teacher questionReceiver)
        {
            questionReceiver.Answer();
        }
    }
    public class Teacher
    {
        public Teacher()
        {
        }
        public void Teach(Student teachWho)
        {
            teachWho.Learn();
        }
        public void Answer()
        {
            Console.WriteLine("The teacher is answering a question");
        }
    }
}
