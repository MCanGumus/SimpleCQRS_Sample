using MediatR;
using Microsoft.EntityFrameworkCore;
using Order.API.Context;
using Order.API.Entities;
using Order.API.MediatR_CQRS.Commands.Requests.Customer;
using Order.API.MediatR_CQRS.Commands.Responses.Customer;

namespace Order.API.MediatR_CQRS.Handlers.CommandHandlers.Customer
{
    public class DeleteCustomerCommandHandler(OrderAPIDbContext context) : IRequestHandler<DeleteCustomerCommandRequest, DeleteCustomerCommandResponse>
    {
        public async Task<DeleteCustomerCommandResponse> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            CustomerEntity customerEntity = await context.Customers.FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId);

            if (customerEntity == null)
            {
                return new DeleteCustomerCommandResponse() { IsSuccess = false };
            }

            context.Customers.Remove(customerEntity);
            await context.SaveChangesAsync();

            return new DeleteCustomerCommandResponse() { IsSuccess = true };
        }
    }
}
