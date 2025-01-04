using CQRSWithDomainEvents.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using CQRSWithDomainEvents.Domain.Entities;
using CQRSWithDomainEvents.Application.Interfaces;

namespace CQRSWithDomainEvents.Application.Customers.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
    {
        private readonly IRepository<Customer> _repository;

        public CreateCustomerCommandHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.Name);
            await _repository.AddAsync(customer);
            return customer.Id;
        }
    }
}
