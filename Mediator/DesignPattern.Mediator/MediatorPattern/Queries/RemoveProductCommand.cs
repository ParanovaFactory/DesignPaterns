using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class RemoveProductCommand : IRequest
    {
        public RemoveProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
