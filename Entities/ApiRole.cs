using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Entities
{
    public class ApiRole : IdentityRole<int>
    {
        public ICollection<ApiUserRole> UserRoles { get; set; }
        public string Pershkrim { get; set; }
    }
}