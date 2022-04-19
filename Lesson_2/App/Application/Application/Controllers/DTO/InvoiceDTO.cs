using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers.DTO
{
    public class InvoiceDTO
    {
        public decimal TotalSum { get; set; }
        public bool IsPayed { get; set; }
    }
}
