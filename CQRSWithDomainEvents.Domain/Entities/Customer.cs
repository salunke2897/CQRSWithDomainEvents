using CQRSWithDomainEvents.Domain.comman;
using CQRSWithDomainEvents.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDomainEvents.Domain.Entities
{
    public class Customer : AggregateRoot
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            Name = name;
            AddDomainEvent(new CustomerCreatedEvent(Id, name));
        }
    }
}
