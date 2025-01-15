using DesignPatern.CQRS.CQRSPattern.Commands;
using DesignPatern.CQRS.DAL;
using Microsoft.AspNetCore.Localization;

namespace DesignPatern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommned commned)
        {
            var values = _context.Products.Find(commned.productId);
            values.name = commned.name;
            values.description = commned.description;
            values.price = commned.price;
            values.status = true;
            values.stock = commned.stock;
            _context.SaveChanges();
        }
    }
}
