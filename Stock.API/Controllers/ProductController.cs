using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.API.Context;
using Stock.API.CQRS.Commands.Requests.Product;
using Stock.API.CQRS.Handlers.CommandHandlers.Product;
using Stock.API.CQRS.Handlers.QueryHandlers.Product;
using Stock.API.CQRS.Queries.Requests.Product;
using Stock.API.Entities;
using Stock.API.ViewModels;

namespace Stock.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController
        (CreateProductCommandHandler createProduct,
        DeleteProductCommandHandler deleteProduct,
        UpdateProductCommandHandler updateProduct,
        GetAllProductsQueryHandler getAllProducts,
        GetProductByIdQueryHandler getByIdProduct) : ControllerBase
    {
        
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductsQueryRequest request) 
            => Ok(await getAllProducts.GetAll(request));

        [HttpGet("{ProductId}")]
        public async Task<IActionResult> Get([FromRoute] GetProductByIdQueryRequest request)
            => Ok(await getByIdProduct.Get(request));

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest request)
            => Ok(await createProduct.CreateProduct(request));

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProductCommandRequest request)
            => Ok(await updateProduct.UpdateProduct(request));

        [HttpDelete("{ProductId}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest request)
            => Ok(await deleteProduct.DeleteProduct(request));
    }
}
