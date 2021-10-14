using Lessons.Models.DataProviders.SqlServer.Repositories;
using Lessons.Models.Entities;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new StudentsRepos();
            student.Update(new Student() { Id = Guid.NewGuid(), Name = "Name Surname" });
        }
    }
}
