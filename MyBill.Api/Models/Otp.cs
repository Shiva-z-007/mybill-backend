namespace MyBill.Api.Models
{
    public class Otp
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Phone { get; set; }
        public string? Code { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public bool IsUsed { get; set; } = false;
    }
}
