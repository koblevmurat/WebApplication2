namespace WebApplication2.model
{
    public class SKU
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public SKU_Category Category { get; set; }
        public string CategotyId { get; set; }
        public decimal price { get; set; }
    }
}
