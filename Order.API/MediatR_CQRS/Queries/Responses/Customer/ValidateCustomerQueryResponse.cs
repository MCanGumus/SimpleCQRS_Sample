using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Order.API.MediatR_CQRS.Queries.Responses.Customer
{
    public class ValidateCustomerQueryResponse
    {
        public bool IsThere{ get; set; }
    }
}
