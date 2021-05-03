namespace BackEnd.Entities
{
    public class Fotografia
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public ApiUser ApiUser { get; set; }
        public int ApiUserId { get; set; }
    }
}