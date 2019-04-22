using Microsoft.AspNetCore.Identity;

namespace Recruter.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        
        public string SecondName { get; set; }

        public string Patronymic { get; set; }
        
        public string Bio { get; set; }
        
        public string Logo { get; set; }

        public UserServicePlan UserServicePlan { get; set; }
    }
}