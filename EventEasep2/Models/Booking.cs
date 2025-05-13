using System.ComponentModel.DataAnnotations;

namespace EventEasep2.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Event is required.")]
        [Display(Name = "Event")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Venue is required.")]
        [Display(Name = "Venue")]
        public int VenueId { get; set; }

        [Required(ErrorMessage = "Booking Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }

        // Navigation properties
        public Event? Event { get; set; }
        public Venue? Venue { get; set; }
    }
}
