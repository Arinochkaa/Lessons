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
        public IQueryable<Course> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
