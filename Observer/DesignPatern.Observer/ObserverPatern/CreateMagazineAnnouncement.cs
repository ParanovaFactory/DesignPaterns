using DesignPatern.Observer.DAL;
using System;

namespace DesignPatern.Observer.ObserverPatern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.userProcesses.Add(new UserProcess
            {
                userNameSurname = appUser.name + " " + appUser.surname,
                magazine = "Science",
                content = "New science magazine arrive your home at first of march, Our subject will be Jupiyter and Mars"
            });
            context.SaveChanges();
        }
    }
}
