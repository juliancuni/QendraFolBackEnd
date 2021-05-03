using System;
using System.Collections.Generic;
using Extensions;
using Microsoft.AspNetCore.Identity;

namespace BackEnd.Entities
{
    public class ApiUser : IdentityUser<int>
    {
        public string Emer { get; set; }
        public string Mbiemer { get; set; }
        public string NrTel { get; set; }
        public string Password { get; set; }
        public ICollection<Fotografia> Fotografite { get; set; }
        public DateTime DiteLindja { get; set; }
        public string Gjinia { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastActive {get;set;}
        public ICollection<ApiUserRole> UserRoles { get; set; }

        // public ICollec tion<AppUserRole> UserRoles { get; set; }
        // public int GetMosha() {
        //     return DiteLindja.LlogaritMoshen();
        // }
    }
}