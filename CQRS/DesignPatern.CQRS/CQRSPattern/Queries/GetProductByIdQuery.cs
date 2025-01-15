namespace DesignPatern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
