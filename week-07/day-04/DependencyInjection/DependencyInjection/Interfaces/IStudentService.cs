using System;
using System.Collections.Generic;

namespace DependencyInjection.Interfaces
{
    public interface IStudentService
    {
         List<string> FindAll();

         void Save(string student);
        
         int StudentCount();
        
         bool StudentChecker(string name);

    }
}
