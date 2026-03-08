using Microsoft.AspNetCore.Mvc;
using CRMWebAPI.Models;

namespace CRMWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {

        }

        [HttpPost]
        public ActionResult ValidateUser(Credential credential)
        {
            if (credential.UserName =="shital" && credential.Password=="jadhav")
            {
                return Ok("Validated");
            }
            else
            {
                //return Unauthorized("Invalid Credential");
                return NotFound();
            }
        }
    }
}