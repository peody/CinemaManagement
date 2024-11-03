// Models/Movie.cs
namespace CinemaManagement.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string ImageUrl { get; set; }
        public string TrailerUrl { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Screening> Screenings { get; set; }
    }
}


// Models/Screening.cs


// Models/Seat.cs


// Models/Customer.cs


// Models/Booking.cs


// Models/BookingDetail.cs
