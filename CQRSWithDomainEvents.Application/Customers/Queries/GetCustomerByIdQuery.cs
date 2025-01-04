using CQRSWithDomainEvents.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDomainEvents.Application.Customers.Queries
{
    public class GetCustomerByIdQuery : IRequest<CustomerDto>
    {
        public Guid Id { get; set; }
    }
}
