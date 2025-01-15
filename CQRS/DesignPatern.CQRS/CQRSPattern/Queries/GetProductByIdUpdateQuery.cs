namespace DesignPatern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIdUpdateQuery
    {
        public GetProductByIdUpdateQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
