using Microsoft.AspNetCore.Mvc;
using CRMWebAPI.Models;

namespace CRMWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {

        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product{ Id=1, Name ="Laptop", Price= 10.99m });
            products.Add(new Product{ Id=1, Name ="Mouse", Price= 10.99m });
            products.Add(new Product{ Id=1, Name ="Keyboard", Price= 10.99m });
            products.Add(new Product{ Id=1, Name ="Monitor", Price= 10.99m });
            products.Add(new Product{ Id=1, Name ="Printer", Price= 10.99m });
            products.Add(new Product{ Id=1, Name ="Webcam", Price= 10.99m });
            products.Add(new Product{ Id=1, Name ="Smart Phone", Price= 10.99m });

            return Ok(products);
        }
    }
}