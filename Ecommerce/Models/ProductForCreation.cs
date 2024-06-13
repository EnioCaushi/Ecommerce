namespace Ecommerce.Models
{
    public class ProductForCreation
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int Stock { get; set; }

        // public int? CategoryID { get; set; }
        // public virtual Category Category { get; set; }
    }
}
