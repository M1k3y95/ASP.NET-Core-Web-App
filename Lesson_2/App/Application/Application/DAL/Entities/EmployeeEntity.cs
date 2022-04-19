using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Domain
{
    /// <summary>
    /// Профиль рабочего
    /// </summary>
    public class EmployeeEntity
    {
        /// <summary>
        /// Имя рабочего
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список задач
        /// </summary>
        public List<TaskEntity> TasksList { get; set; }
    }
}
