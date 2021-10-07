using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons.Models.Repositories;

namespace Lessons.Models
{
    public record DataManager (ICoursesRepository CoursesRepository, IStudentsRepository StudentsRepository);
    
}
