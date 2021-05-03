using Microsoft.AspNetCore.Identity;

namespace BackEnd.Entities
{
    public class ApiUserRole : IdentityUserRole<int>
    {
        public ApiUser User { get; set; }
        public ApiRole Role { get; set; }
    }
}