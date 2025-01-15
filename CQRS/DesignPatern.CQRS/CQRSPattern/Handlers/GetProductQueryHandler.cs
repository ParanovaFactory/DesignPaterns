using DesignPatern.CQRS.CQRSPattern.Results;
using DesignPatern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x=>new GetProductQueryResult
            {
                Id = x.productId,
                productNmae = x.name,
                stock = x.stock,
                price = x.price
            }).ToList();
            return values;
        }
    }
}
