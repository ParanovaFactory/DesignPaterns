using DesignPatern.CQRS.CQRSPattern.Commands;
using DesignPatern.CQRS.DAL;

namespace DesignPatern.CQRS.CQRSPattern.Handlers
{
    public class CrateProductCommentHandler
    {
        private readonly Context _context;

        public CrateProductCommentHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductComment comment)
        {
            _context.Products.Add(new Product
            {
                description = comment.description,
                name = comment.name,
                price = comment.price,
                status = true,
                stock = comment.stock
            });
            _context.SaveChanges();
        }
    }
}
