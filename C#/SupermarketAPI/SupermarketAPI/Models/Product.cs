namespace SupermarketAPI.Models
{
    public class Product
    {
        // Properties: Phai viet hoa ten
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public List<Order> Orders { get; set; }
    }
}
