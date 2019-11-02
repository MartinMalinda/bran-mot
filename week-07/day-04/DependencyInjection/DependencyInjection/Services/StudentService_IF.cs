using System;
using System.Collections.Generic;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class StudentService_IF : IStudentService
    {
        private readonly List<string> names;

        public StudentService_IF()
        {
            names = new List<string> { "Sanyi", "Lilla", "John" };
        }

        public List<string> FindAll()
        {
            return names;
        }

        public void Save(string student)
        {
            names.Add(student);
        }
        public int StudentCount()
        {
            return names.Count;
        }

        public bool StudentChecker(string name)
        {
            return names.Contains(name);
        }
    }
}
