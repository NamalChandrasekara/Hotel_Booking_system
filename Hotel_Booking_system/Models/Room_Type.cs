using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_system.Models
{
    public class Room_Type
    {
        [Key]
        public int R_ID { get; set; }
        public string R_name { get; set; } = default!;
        public int Amount { get; set; } = default!;

    }
}
