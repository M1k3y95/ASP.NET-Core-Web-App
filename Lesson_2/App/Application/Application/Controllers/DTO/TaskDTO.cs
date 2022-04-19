using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers.DTO
{
    public class TaskDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public bool IsComplete { get; set; }
    }
}
