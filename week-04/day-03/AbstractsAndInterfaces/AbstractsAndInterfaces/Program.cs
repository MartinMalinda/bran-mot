using System;

namespace AbstractsAndInterfaces
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
        }
        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi I'm {Name}, a {Age} old {Gender}");
        }
        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
    class Student : Person, ICloneable
    {
        public string PreviousOrg { get; set; }
        public int SkippedDays { get; set; }

        public Student()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.PreviousOrg = "The School of Life";
            this.SkippedDays = 0;
        }

        public Student(string name, int age, string gender, string previousOrg) : base(name, age, gender)
        {
            this.PreviousOrg = previousOrg;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer");
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays = numberOfDays;
        }

        public object Clone()
        {
            return new Student(this.Name, this.Age, this.Gender, this.PreviousOrg);
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student John = new Student("John", 20, "male", "BGE");

            Student JohnTheClone = (Student) John.Clone();

            Console.WriteLine($"{JohnTheClone.Name}, {JohnTheClone.Age}, {JohnTheClone.Gender}, {JohnTheClone.PreviousOrg} ");
        }
    }
}
