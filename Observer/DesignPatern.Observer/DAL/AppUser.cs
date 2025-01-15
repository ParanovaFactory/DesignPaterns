using Microsoft.AspNetCore.Identity;

namespace DesignPatern.Observer.DAL
{
    public class AppUser : IdentityUser<int>
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string city { get; set; }
        public string province { get; set; }
    }
}
