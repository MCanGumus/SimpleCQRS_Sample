using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Customer;
using Order.API.MediatR_CQRS.Commands.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Customer
{
    public class UpdateCustomerCommandHandler(OrderAPIDbContext context) : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        public async Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            CustomerEntity customerEntity = await context.Customers.FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId);

            if (customerEntity == null)
            {
                return new UpdateCustomerCommandResponse() { IsSuccess = false };
            }

            customerEntity.AddressId = request.AddressId;
            customerEntity.UpdatedAt = DateTime.Now;
            customerEntity.Email = request.Email;
            customerEntity.Name = request.Name;

            context.Customers.Update(customerEntity);

            await context.SaveChangesAsync();

            return new UpdateCustomerCommandResponse() { IsSuccess = true };
        }
    }
}
