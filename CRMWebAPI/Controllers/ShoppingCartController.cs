using Microsoft.AspNetCore.Mvc;
using CRMWebAPI.Models;

namespace CRMWebAPI.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        public ShoppingCartController()
        {

        }

        [HttpPost("add")]
        public ActionResult AddToCart(CartItem cartItem)
        {
            return Ok("Item added to Cart");
        }

        [HttpDelete("remove")]
        public ActionResult RemoveFromCart(CartItem cartItem)
        {
            return Ok("Item removed from cart");
        }

        [HttpGet("{customerId}")]
        public ActionResult<List<CartItem>> GetCart(int customerId)
        {
            var cart = new Cart{
                Id = 1, CustomerId=customerId,
                CartItems = new List<CartItem>
                {
                    new CartItem {Id = 1, ProductId = 1, Quantity = 1},
                    new CartItem {Id = 2, ProductId = 2, Quantity = 2}
                }
            };
            return Ok(cart);
        }
    }
}