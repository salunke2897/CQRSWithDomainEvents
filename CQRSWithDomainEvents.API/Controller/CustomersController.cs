using CQRSWithDomainEvents.Application.Customers.Commands;
using CQRSWithDomainEvents.Application.Customers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWithDomainEvents.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }
        /// <summary>
        /// Gets a customer by their ID.
        /// </summary>
        /// <param name="id">The ID of the customer.</param>
        /// <returns>A customer object.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            var customer = await _mediator.Send(new GetCustomerByIdQuery { Id = id });
            return customer != null ? Ok(customer) : NotFound();
        }
    }

}
