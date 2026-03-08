using Microsoft.AspNetCore.Mvc;
using CRMWebAPI.Models;

namespace CRMWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersProcessingController : ControllerBase
    {
        public OrdersProcessingController()
        {

        }

        [HttpPost]
        public ActionResult ProcessOrder(Order order)
        {
            return Ok("Order processed");
        }
    }
}