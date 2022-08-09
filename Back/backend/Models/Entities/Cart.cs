namespace backend.Models.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public List<CartItem> Items { get; set; }
        public User User { get; set; }
        public decimal Total { get; set; }

    }
}
