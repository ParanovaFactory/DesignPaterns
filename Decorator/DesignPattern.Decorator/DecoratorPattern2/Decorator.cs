﻿using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class Decorator : ISendMessage
    {
        private readonly ISendMessage _sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        virtual public void SendMessage(Message message)
        {
            message.MessageSender = "Admin";
            message.MessageReceiver = "Everyone";
            message.MessageSubject = "Meeting";
            message.MessageContent = "Hello this is a meeting message";
            _sendMessage.SendMessage(message);
        }
    }
}
