using System;
using System.Collections.Generic;
using Extensions;

namespace Entities
{
    public class ApiUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Emer { get; set; }
        public string Mbiemer { get; set; }
        public string NrTel { get; set; }
        public string Password { get; set; }
        public ICollection<Fotografia> Fotografite { get; set; }
        public DateTime DiteLindja { get; set; }
        public string Gjinia { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        // public ICollec tion<AppUserRole> UserRoles { get; set; }
        // public int GetMosha() {
        //     return DiteLindja.LlogaritMoshen();
        // }
    }
}