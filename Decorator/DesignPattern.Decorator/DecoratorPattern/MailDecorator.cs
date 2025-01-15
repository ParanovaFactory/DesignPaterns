using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        Context context = new Context();
        private readonly INotifier _notifier;

        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }

        public void SendMailNotify(Notifier notifier)
        {
            notifier.NotifierSubject = "Daily Morning Meeting";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierChannel = "G-Mail-Outlook";
            notifier.NotifierType = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }

        public override void CreateNotifier(Notifier notifier)
        {
            base.CreateNotifier(notifier);
            SendMailNotify(notifier);
        }
    }
}
