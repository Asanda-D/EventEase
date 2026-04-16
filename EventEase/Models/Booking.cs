using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Please select a venue")]
        public int VenueId { get; set; }

        [Required(ErrorMessage = "Please select an event")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Booking date is required")]
        [DataType(DataType.DateTime)]
        public DateTime BookingDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Booking reference is required")]
        [StringLength(50, ErrorMessage = "Booking reference cannot exceed 50 characters")]
        [RegularExpression(@"^[A-Z0-9\-]+$", ErrorMessage = "Use only uppercase letters, numbers, and hyphens")]
        public string BookingReference { get; set; } = string.Empty;

        // Navigation Properties
        public Venue? Venue { get; set; }
        public Event? Event { get; set; }

    }//end of public class Booking

}//end of namespace EventEase.Models
