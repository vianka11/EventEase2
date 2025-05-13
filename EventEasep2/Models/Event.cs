using System.ComponentModel.DataAnnotations;

namespace EventEasep2.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        public string? Description { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}
