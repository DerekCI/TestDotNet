namespace Test.Models
{
    public class Inventory
    {
        public int itemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public User user{ get; set; } 
    }
}
