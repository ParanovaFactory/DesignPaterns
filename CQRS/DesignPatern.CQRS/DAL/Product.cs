namespace DesignPatern.CQRS.DAL
{
    public class Product
    {
        public int productId { get; set; }
        public string name { get; set; }
        public int stock { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
    }
}
