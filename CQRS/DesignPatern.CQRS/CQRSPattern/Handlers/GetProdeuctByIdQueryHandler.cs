using DesignPatern.CQRS.CQRSPattern.Queries;
using DesignPatern.CQRS.CQRSPattern.Results;
using DesignPatern.CQRS.DAL;

namespace DesignPatern.CQRS.CQRSPattern.Handlers
{
    public class GetProdeuctByIdQueryHandler
    {
        private readonly Context _context;

        public GetProdeuctByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQureyResult Handle(GetProductByIdUpdateQuery query)
        {
            var values = _context.Products.Find(query.id);
            return new GetProductUpdateQureyResult
            {
                description = values.description,
                name = values.name,
                price = values.price,
                productId = values.productId,
                stock = values.stock
            };
        }
    }
}
