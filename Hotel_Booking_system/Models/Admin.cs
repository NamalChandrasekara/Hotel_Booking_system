using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_system.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Email { get; set; }
        public int age { get; set; }

    }
}
