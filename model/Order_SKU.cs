namespace WebApplication2.model
{
    public class Order_SKU
    {
        public string Id { get; set; }
        public  Order order_id { get; set; }
        public SKU SKU_Id { get; set; }
        public decimal amount { get; set; }
        public decimal sum { get; set; }
    }
}
