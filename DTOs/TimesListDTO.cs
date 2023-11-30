using System.ComponentModel.DataAnnotations;

namespace YVTestServer.DTOs
{
    public record TimesListDTO
    {
        [Required]
        public string startTime { get; set; } = string.Empty;
        [Required]
        public int availablePlaces { get; set; }
        [Required]
        public bool isClosed { get; set; }

        public TimesListDTO() { }
        public TimesListDTO(string startTime, int availablePlaces, bool isClosed = false)
        {
            this.startTime = startTime;
            this.availablePlaces = availablePlaces;
            this.isClosed = isClosed;
        }
        public TimesListDTO(TimesListDTO dto)
        {
            startTime = dto.startTime;
            availablePlaces = dto.availablePlaces;
            isClosed = dto.isClosed;
        }
    }
}
