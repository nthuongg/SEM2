namespace SupermarketAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = new DateTime();
        public string Total { get; set; }

        public Customer Customer { get; set; }

        public List<Product> Products { get; set; }
    }
}
