using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_system.Models
{
    public class HRBSContext : DbContext
    {
        public HRBSContext(DbContextOptions<HRBSContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            ; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Room_Type> Room_Types{get;set;}


    }
}
