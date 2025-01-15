using DesignPatern.Observer.DAL;
using System;

namespace DesignPatern.Observer.ObserverPatern
{
    public class CreateDiscauntCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscauntCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.discaunts.Add(new Discaunt
            {
                dicauntCode = "DISCOUNTMARCH",
                dicauntAmount = "%35",
                dicauntCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
