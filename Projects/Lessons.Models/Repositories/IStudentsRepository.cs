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
    public interface IStudentsRepository
    {
        /// <summary>
        /// перечисление всех студентов
        /// </summary>
        IQueryable<Student> Items { get; }
        /// <summary>
        /// получаем данные о студенте
        /// </summary>
        /// <param name="id"> номер студента в бд </param>
        /// <returns> студент </returns>
        Student? GetStudentById(Guid id);
        /// <summary>
        /// удаление студента
        /// </summary>
        /// <param name="id"> номер студента </param>
        void Delete(Guid id);
        /// <summary>
        /// обновление или добавление студента
        /// </summary>
        /// <param name="Student"> студент </param>
        void Update(Student Student);
    }
}

