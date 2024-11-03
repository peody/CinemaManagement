namespace CinemaManagement.Models
{
    public class BookingDetail
    {
        public int BookingDetailId { get; set; }
        public int BookingId { get; set; }
        public int SeatId { get; set; }
        public decimal Price { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Seat Seat { get; set; }
    }
}
