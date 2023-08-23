namespace SupermarketAPI.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
