using MediatR;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Customer;
using Order.API.MediatR_CQRS.Commands.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Customer
{
    public class CreateCustomerCommandHandler(OrderAPIDbContext context) : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            CustomerEntity customerEntity = new()
            {
                CustomerId = Guid.NewGuid(),
                Email = request.Email,
                Name = request.Name,
                AddressId = request.AddressId,
                CreatedAt = DateTime.Now,
            };

            context.Customers.Add(customerEntity);

            await context.SaveChangesAsync();

            return new CreateCustomerCommandResponse() { CustomerId = customerEntity.CustomerId};
        }
    }
}
