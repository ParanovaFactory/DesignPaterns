namespace DesignPatern.CQRS.CQRSPattern.Results
{
    public class GetProductUpdateQureyResult
    {
        public int productId { get; set; }
        public string name { get; set; }
        public int stock { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    }
}
