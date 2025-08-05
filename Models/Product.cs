namespace InternTask2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string Description { get; set; } = null!;

        // Foreign key for Category
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; } = null!;
    }

}
