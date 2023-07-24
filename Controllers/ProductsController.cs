using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;


namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "car", Description = "toyota car" },
            new Product { Id = 2, Name = "mobile", Description = "iphone 14 pro" },
        };


        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return Products;
        }
    }
}
