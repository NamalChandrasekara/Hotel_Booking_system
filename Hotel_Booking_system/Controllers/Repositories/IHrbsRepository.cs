using Hotel_Booking_system.Models;

namespace Hotel_Booking_system.Controllers.Repositories
{
    public interface IHrbsRepository
    {
        Task<IEnumerable<Admin>> Get();
        Task<Admin> Get(int AdminID);
        Task<Admin> Create(Admin admin);
        Task<Admin> Update(Admin admin);
        Task<Admin> Delaete(int AdminID);
    }
}
