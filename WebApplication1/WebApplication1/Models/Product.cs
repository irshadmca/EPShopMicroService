namespace WebApplication1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = default!;
        public int CategoryId { get; set; }

        public ICollection<Category>? Category  { get; set; } 

}
}
