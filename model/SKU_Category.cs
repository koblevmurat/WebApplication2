using WebApplication2.Migrations;

namespace WebApplication2.model
{
    public class SKU_Category
    {
        //public SKU_Category() {
        //    this.SKUs = new HashSet<SKUs>();
        //}
        public string Id { get; set; } = null!;
        public string Name { get; set; }
        public virtual ICollection<SKU> SKUs { get; set; }
    }
}
