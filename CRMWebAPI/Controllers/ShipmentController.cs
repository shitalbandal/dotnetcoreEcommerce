using Microsoft.AspNetCore.Mvc;
using CRMWebAPI.Models;

namespace CRMWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipmentController : ControllerBase
    {
        public ShipmentController()
        {

        }

        [HttpPost]
        public ActionResult ProcessShipment(Shipment shipment)
        {
            return Ok("shipment processed successfully.");
        }
    }
}