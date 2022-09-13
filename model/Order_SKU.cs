namespace WebApplication2.model
{
    public class Order_SKU
    {
        public string Id { get; set; }
        public  Order order_ref { get; set; }
        public string skuId { get; set; }
        public SKU sku_ref { get; set; }
        public decimal amount { get; set; }
        public decimal sum { get; set; }
    }
}
