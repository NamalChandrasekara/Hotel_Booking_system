using Hotel_Booking_system.Controllers.Repositories;
using Hotel_Booking_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Booking_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrbsControllers : ControllerBase
    {
        private readonly IHrbsRepository _hrbsRepository;
        public HrbsControllers(IHrbsRepository hrbsRepository)
        {
            _hrbsRepository = hrbsRepository;
            
        }
        [HttpGet]
        public async Task<IEnumerable<Admin>> GetAdmins()
        {
            return await _hrbsRepository.Get();
        }
        [HttpGet("{AdminId}")]
        public async Task<ActionResult<Admin>> GetAdmins(int AdminID)
        {
            return await _hrbsRepository.Get(AdminID);
        }
        [HttpPost]
        public async Task<ActionResult<Admin>> PostAdmins([FromBody] Admin admin)
        {
            var newAdmin = await _hrbsRepository.Create(admin);
            return CreatedAtAction(nameof(GetAdmins), new { AdminID = newAdmin.AdminID });

        }
        [HttpPut]
        public async Task<ActionResult> PutAdmins(int AdminID, [FromBody] Admin admin)
        {
            if(AdminID!=admin.AdminID)
            {
                return BadRequest();
            }
            await _hrbsRepository.Update(admin);
            return NoContent();
        }
        [HttpDelete("{AdminID}")]
        public async Task<ActionResult> Delete(int AdminID)
        {
            var adminToDelete = await _hrbsRepository.Get(AdminID);
            if (adminToDelete == null)
                return NotFound();
            await _hrbsRepository.Delaete(adminToDelete.AdminID);
            return NoContent();
        }

       
    }
}
