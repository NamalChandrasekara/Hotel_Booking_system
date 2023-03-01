namespace Hotel_Booking_system.Models
{
    public class Payment
    {
        public int Payment_ID { get; set; }
        public int Customer_No { get; set; }
        public string Trans_Date { get; set; } = default!;
        public int Total_Payment{get; set;}
        public string Payment_type { get; set; } = default!;
    }
}
