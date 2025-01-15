using DesignPatern.Observer.DAL;

namespace DesignPatern.Observer.ObserverPatern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
