using Lessons.Models.Entities;
using Lessons.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Models.DataProviders.SqlServer.Repositories
{
    public class StudentsRepos : IStudentsRepository
    {
        LessonsContext context = new();

        public IQueryable<Student> Items => context.Students;

        public void Delete(Guid id)
        {
            var result = GetStudentById(id);
            if (result == null) return;
            //IQueryable<Course> courses = new CoursesRepos().Items;
            //var delfromstud = courses.Where(c => c.Id == id);
            //if (delfromstud.Any())
            //{
            //    foreach (var d in delfromstud)
            //    {
            //        d.Students.Remove(result);
            //    }
            //}
            context.Remove(result);
        }

        public Student? GetStudentById(Guid id) => Items.FirstOrDefault(i => i.Id == id);

        public void Update(Student student)
        {
            var result = GetStudentById(student.Id);
            if (result == null) context.Add(student);
            else context.Update(student);
            context.SaveChanges();
        }
    }
}
