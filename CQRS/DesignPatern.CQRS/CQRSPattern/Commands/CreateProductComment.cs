namespace DesignPatern.CQRS.CQRSPattern.Commands
{
    public class CreateProductComment
    {
        public int productId { get; set; }
        public string name { get; set; }
        public int stock { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    }
}
