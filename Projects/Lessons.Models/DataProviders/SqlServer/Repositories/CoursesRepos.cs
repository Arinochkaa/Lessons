using Lessons.Models.Entities;
using Lessons.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Models.DataProviders.SqlServer.Repositories
{
    public class CoursesRepos : ICoursesRepository
    {
        LessonsContext context = new();
        IQueryable<Student> students = new StudentsRepos().Items;

        public IQueryable<Course> Items => context.Courses;

        public void Delete(Guid id)
        {
            var result = GetCourseById(id);
            if (result == null) return;
            var delfromcours = students.Where(s => s.Id == id);
            if (delfromcours.Any())
            {
                foreach (var d in delfromcours)
                {
                    d.Courses.Remove(result);
                }
            }
            context.Remove(result);
           

        }

        public Course? GetCourseById(Guid id) => Items.FirstOrDefault(i => i.Id == id);

        public void Update(Course course)
        {
            var result = GetCourseById(course.Id);
            if (result == null) context.Add(course);
            else context.Update(course);
            context.SaveChanges();
        }
    }
}
