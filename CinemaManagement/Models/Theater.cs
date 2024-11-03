namespace CinemaManagement.Models
{
    public class Theater
    {
            public int TheaterId { get; set; }
            public string TheaterName { get; set; }
            public int Capacity { get; set; }
            public string TheaterType { get; set; }
            public bool Status { get; set; }

            public virtual ICollection<Screening> Screenings { get; set; }
            public virtual ICollection<Seat> Seats { get; set; }
       
    }
}
