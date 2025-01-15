using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value =  _context.Products.Find(request.ProductId);
            value.ProductName = request.ProductName;
            value.ProductPrice = request.ProductPrice;
            value.ProductCategory = request.ProductCategory;
            value.ProductStock = request.ProductStock;
            await _context.SaveChangesAsync();
        }
    }
}
