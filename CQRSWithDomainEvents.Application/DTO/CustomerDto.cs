using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDomainEvents.Application.DTO
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
