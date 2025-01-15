using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductByIdUpdateQuery :IRequest<UpdateProductByIdQueryResult>
    {
        public GetProductByIdUpdateQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
