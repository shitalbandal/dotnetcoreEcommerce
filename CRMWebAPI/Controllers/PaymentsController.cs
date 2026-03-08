using Microsoft.AspNetCore.Mvc;
using CRMWebAPI.Models;

namespace CRMWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        public PaymentsController()
        {

        }

        [HttpPost]
        public ActionResult ProcessPayment(Payment payment)
        {
            return Ok("Payment processed successfully.");
        }
    }
}