namespace CinemaManagement.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int TheaterId { get; set; }
        public char SeatRow { get; set; }
        public int SeatNumber { get; set; }
        public string SeatType { get; set; }
        public bool Status { get; set; }

        public virtual Theater Theater { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
