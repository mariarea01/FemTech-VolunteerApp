using Microsoft.AspNetCore.Identity;

/// This Class is essentially adding to the default tables that come with Identity. 
/// I'm adding First Name, Last Name and a Admin Id to the User table that was created by Identity


namespace FemTechVolunteerWebApplication.Data
{
    public class AdminUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AdminId { get; set; } 

    }
}
