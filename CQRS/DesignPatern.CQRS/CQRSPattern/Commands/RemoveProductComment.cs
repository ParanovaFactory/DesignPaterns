namespace DesignPatern.CQRS.CQRSPattern.Commands
{
    public class RemoveProductComment
    {
        public RemoveProductComment(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
