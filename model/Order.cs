namespace WebApplication2.model
{
    public class Order
    {
        public string Id { get; set; }
        public Customer Customer_Id{ get; set; }
        public DateTime Order_Date { get; set; }
        public virtual ICollection<Order_SKU> Order_SKUs { get; set; }
    }
}
