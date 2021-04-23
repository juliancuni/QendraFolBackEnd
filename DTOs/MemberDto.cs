using System;
using System.Collections.Generic;

namespace DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Emer { get; set; }
        public string Mbiemer { get; set; }
        public string NrTel { get; set; }
        public string FotografiaUrl { get; set; }
        public ICollection<FotografiaDto> Fotografite { get; set; }
        public int Mosha { get; set; }
        public string Gjinia { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}