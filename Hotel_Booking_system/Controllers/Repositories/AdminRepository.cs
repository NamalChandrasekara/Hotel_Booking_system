using Hotel_Booking_system.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SQLitePCL;

namespace Hotel_Booking_system.Controllers.Repositories
{
    public class AdminRepository : IHrbsRepository
    {
        private readonly HRBSContext _context;
        public AdminRepository(HRBSContext context)
        {
            _context = context;
        }

        public async Task<Admin> Create(Admin admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
            return admin;
        }

        public async Task<Admin> Delaete(int AdminID)
        {
            var adminToDelete = await _context.Admins.FindAsync(AdminID);
            _context.Admins.Remove(adminToDelete);
            await _context.SaveChangesAsync();
            return adminToDelete;
        }

        public async Task<IEnumerable<Admin>> Get()
        {
            return await _context.Admins.ToListAsync();

        }

        public async Task<Admin> Get(int AdminID)
        {
            return await _context.Admins.FindAsync(AdminID);

        }

        public async Task<Admin> Update(Admin admin)
        {
            _context.Entry(admin).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return admin;
        }
    }
}
