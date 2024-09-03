using AngularSlideShowApi.Models;
using AngularSlideShowApi.Repositories;
using AngularSlideShowApi.Responses;
using Microsoft.AspNetCore.Mvc;

namespace AngularSlideShowApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository repository;

        public ProductsController(ProductRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var response = new ProductListResponse();
            response.Items = repository.GetAll();
            return Ok(response);
            //test//
        }
    }
}
