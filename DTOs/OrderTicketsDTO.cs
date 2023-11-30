using System.ComponentModel.DataAnnotations;

namespace YVTestServer.DTOs
{
    public record OrderTicketsDTO
    {
        [Required]
        public string startTime { get; set; } = string.Empty;
        [Required]
        public int amount { get; set; }
    }
}
