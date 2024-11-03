namespace CinemaManagement.Models
{
    public class Screening
    {
        
            public int ScreeningId { get; set; }
            public int MovieId { get; set; }
            public int TheaterId { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public decimal Price { get; set; }
            public bool Status { get; set; }

            public virtual Movie Movie { get; set; }
            public virtual Theater Theater { get; set; }
            public virtual ICollection<Booking> Bookings { get; set; }
        
    }
}
