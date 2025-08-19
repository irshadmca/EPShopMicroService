namespace WebApplication1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = default!;
        public int ProductId { get; set; }
        //public Product? Product { get; set; } = new();

    }
}
