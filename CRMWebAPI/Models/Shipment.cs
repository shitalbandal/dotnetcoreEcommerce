namespace CRMWebAPI.Models
{
    public class Shipment
    {
        public int Id { get; set;}
        public int OrderId { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime ShipmentDate { get; set;}
    }
}