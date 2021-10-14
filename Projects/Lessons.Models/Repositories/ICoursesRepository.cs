using Lessons.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Models.Repositories
{
    /// <summary>
    /// операции с курсами 
    /// </summary>
    public interface ICoursesRepository
    {
        /// <summary>
        /// перечисление всех курсов
        /// </summary>
       IQueryable<Course> Items { get; }
        /// <summary>
        /// получаем данные о курсе
        /// </summary>
        /// <param name="id"> номер курса в бд </param>
        /// <returns> курс </returns>
        Course? GetCourseById(Guid id);
        /// <summary>
        /// удаление курса
        /// </summary>
        /// <param name="id"> номер курса </param>
         void Delete(Guid id);
        /// <summary>
        /// обновление или создание нового курса
        /// </summary>
        /// <param name="course"> курс </param>
        void Update(Course course) ;
    }
}
