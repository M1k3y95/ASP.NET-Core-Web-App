using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Domain
{
    /// <summary>
    /// Задача на выполнение
    /// </summary>
    public class TaskEntity
    {
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дополнительное описание задачи
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена вопроса
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Дата регистрации задачи
        /// </summary>
        public DateTime RegistrationDate => DateTime.Now;

        /// <summary>
        /// Факт выполнения
        /// </summary>
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Дата завершения
        /// </summary>
        public DateTime CompleteDate { get; private set; }

        /// <summary>
        /// Задача выполнена
        /// </summary>
        public void TaskCompleted()
        {
            IsCompleted = true;
            CompleteDate = DateTime.Now;
        }
    }
}
