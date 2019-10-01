using System;
using System.Collections.Generic;

namespace People 
{
    class Person
    {
        public int Age;
        public string Name;
    }
}

namespace inhertiance 
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
    class Student : Person
    {
        //Create a Student class that has the same fields and methods as the Person class, and has the following additional
        //fields:
        //previousOrganization: the name of the student’s previous company / school
        //skippedDays: the number of days skipped from the course
        public string PreviousOrg { get; set; }
        public int SkippedDays { get; set; }

        //Student(name, age, gender, previousOrganization) : beside the given parameters, it sets skippedDays to 0
        //Student() : sets name to Jane Doe, age to 30, gender to female, previousOrganization to The School of Life, skippedDays to 0
        public Student()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.PreviousOrg = "The School of Life";
            this.SkippedDays = 0;
        }

        public Student (string name, int age, string gender, string previousOrg) : base(name,age, gender)
        {
            this.PreviousOrg = previousOrg;
        }

        //methods:
        //GetGoal() : prints out "Be a junior software developer."
        //Introduce() : "Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already."
        //SkipDays(numberOfDays) : increases skippedDays by numberOfDays
        //The Student class has the following constructors:

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer");
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays = numberOfDays;
        }
    }

    class Mentor : Person
    {
        public string Level { get; set; }


        public Mentor() : base()
        {
            this.Level = "intermediate";
        }

        public Mentor(string name, int age, string gender, string level) :base(name, age, gender)
        {
            this.Level = level;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi my name is {Name} a {Age} year old {Level} Mentor");
        }
    }

    class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor() : base()
        {
            this.Company = "Google";
            this.HiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company):base(name, age, gender)
        {
            this.Company = company;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public override void GetGoal()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }
        public void Hire()
        {
            HiredStudents++;
        }
    }

    class Cohort
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Mentor> Mentors { get; set; }

        public Cohort(string name)
        {
            this.Name = name;
            Students = new List<Student>();
            Mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {Name} cohort has {Students.Count} students and {Mentors.Count} mentors");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var mark = new Person("Mark", 46, "male");
            people.Add(mark);
            var jane = new Person();
            people.Add(jane);
            var john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);
            var student = new Student();
            people.Add(student);
            var gandhi = new Mentor("Gandhi", 148, "male", "senior");
            people.Add(gandhi);
            var mentor = new Mentor();
            people.Add(mentor);
            var sponsor = new Sponsor();
            people.Add(sponsor);
            var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            people.Add(elon);

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }

            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            Cohort awesome = new Cohort("AWESOME");
            awesome.AddStudent(student);
            awesome.AddStudent(john);
            awesome.AddMentor(mentor);
            awesome.AddMentor(gandhi);
            awesome.Info();
        }
    }
}
