using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers.DTO
{
    public class ContractDTO
    {
        public string ContractName { get; set; }
        public ClientDTO Client { get; set; }
        public DateTime ContractDate { get; set; }
        public string Description { get; set; }

    }
}
