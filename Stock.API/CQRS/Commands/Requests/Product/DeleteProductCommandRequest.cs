using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stock.API.CQRS.Commands.Requests.Product
{
    public class DeleteProductCommandRequest 
    {
        public Guid ProductId { get; set; }
    }
}
