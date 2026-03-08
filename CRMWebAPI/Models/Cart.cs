namespace CRMWebAPI.Models
{
    public class Cart 
    {
        public int Id {get; set;}
        public int CustomerId { get; set; }
        public List<CartItem> CartItems { get; set;} = new List<CartItem>();
    }
}