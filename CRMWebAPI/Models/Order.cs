namespace CRMWebAPI.Models
{
    public class Order 
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public decimal TotalAmount { get; set; }
    }
}