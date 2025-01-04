using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDomainEvents.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
    }
}
