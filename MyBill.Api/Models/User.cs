namespace MyBill.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public bool IsPhoneVerified { get; set; }
        public string? ProfileImagePath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
