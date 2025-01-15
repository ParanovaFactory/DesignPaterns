using DesignPatern.CQRS.CQRSPattern.Queries;
using DesignPatern.CQRS.CQRSPattern.Results;
using DesignPatern.CQRS.DAL;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace DesignPatern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByResultIdResult Handle(GetProductByIdQuery query) 
        {
            var values = _context.Set<Product>().Find(query.id);
            return new GetProductByResultIdResult
            {
                name = values.name,
                price = values.price,
                productId = values.productId,
                stock = values.stock
            };
        }
    }
}
