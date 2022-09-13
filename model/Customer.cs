namespace WebApplication2.model
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
