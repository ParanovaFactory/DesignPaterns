using DesignPatern.Observer.DAL;
using System;

namespace DesignPatern.Observer.ObserverPatern
{
    public class WelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public WelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.welcomeMessages.Add(new DAL.WelcomeMessage
            {
                NameSurname = appUser.name + " " + appUser.surname,
                Content = "Thank you very much for subscribing to our magazine newsletter. You can access our magazine list on our website."
            });
            context.SaveChanges();
        }
    }
}
