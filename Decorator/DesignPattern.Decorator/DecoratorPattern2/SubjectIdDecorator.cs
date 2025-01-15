using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIdDecorator : Decorator
    {
        Context context = new Context();
        private readonly ISendMessage _sendMessage;

        public SubjectIdDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageIdSubject(Message message)
        {
            if (message.MessageSubject == "1")
            {
                message.MessageSubject = "Meeting";
            }
            else if (message.MessageSubject == "2")
            {
                message.MessageSubject = "Scrum Meeting";
            }
            else if (message.MessageSubject == "3")
            {
                message.MessageSubject = "Weakly Meeting";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIdSubject(message);
        }
    }
}
