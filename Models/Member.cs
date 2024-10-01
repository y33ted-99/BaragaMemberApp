namespace BaragaMemberApp.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Street { get; set; }

        public string? City { get; set; }

        public string? Province { get; set; }

        public string? PostalCode { get; set; }

        public string? MobilePhone { get; set; }

        public string? Email { get; set; }

        public bool IsReceiveEmail { get; set; } = false; // Default value
    }
}
