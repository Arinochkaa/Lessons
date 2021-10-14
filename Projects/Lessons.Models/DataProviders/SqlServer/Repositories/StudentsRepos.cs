﻿using Lessons.Models.Entities;
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
            context.Remove(result);
            context.SaveChanges();
        }

        public Student? GetStudentById(Guid id) => Items.FirstOrDefault(i => i.Id == id);

        public void Update(Student Student)
        {
            var result = GetStudentById(Student.Id);
            if (result == null) context.Add(Student);
            else context.Update(Student);
            context.SaveChanges();
        }
    }
}
