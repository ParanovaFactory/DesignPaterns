
namespace DesignPatern.CQRS.CQRSPattern.Results
{
    public class GetProductQueryResult
    {
        public int Id { get; set; }
        public string productNmae { get; set; }
        public int stock {  get; set; }
        public decimal price {  get; set; }
    }
}
