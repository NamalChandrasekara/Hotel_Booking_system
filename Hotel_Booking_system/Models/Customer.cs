namespace Hotel_Booking_system.Models
{
    public class Customer
    {
        public int Customer_ID { get; set; }
        public int Phone_num { get; set; }
        public string Customer_fname { get; set; } = default!;
        public string Customer_lname { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string Town { get; set; } = default!;

    }
}
