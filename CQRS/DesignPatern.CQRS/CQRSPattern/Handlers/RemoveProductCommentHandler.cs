using DesignPatern.CQRS.CQRSPattern.Commands;
using DesignPatern.CQRS.DAL;

namespace DesignPatern.CQRS.CQRSPattern.Handlers
{
    public class RemoveProductCommentHandler
    {
        private readonly Context _context;

        public RemoveProductCommentHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductComment remove)
        {
            var values = _context.Products.Find(remove.id);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
