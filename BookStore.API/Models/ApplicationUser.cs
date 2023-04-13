using Microsoft.AspNetCore.Identity;

namespace BookStore.API.Models
{
    // for identity -> we have to inherit class by identityuser
    // go to definition for properties
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
