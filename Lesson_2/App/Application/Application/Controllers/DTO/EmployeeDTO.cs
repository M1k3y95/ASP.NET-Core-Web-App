using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers.DTO
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public List<TaskDTO> TaskList { get; set; }
    }
}
