using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stock.API.CQRS.Commands.Requests.Product
{
    public class CreateProductCommandRequest
    {
        public required string ImageUrl { get; set; }
        public required string Name { get; set; }
        public int Quantity { get; set; }
    }
}
