namespace CinemaManagement.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MembershipLevel { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
