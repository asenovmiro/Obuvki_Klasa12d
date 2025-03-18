using Microsoft.AspNetCore.Identity;

namespace Obuvki_Klasa.Models
{
    public class Client: IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistratiOn { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
