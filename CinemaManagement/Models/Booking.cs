namespace CinemaManagement.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Screening Screening { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
