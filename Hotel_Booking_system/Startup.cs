using Hotel_Booking_system.Controllers.Repositories;
using Hotel_Booking_system.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_system
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IHrbsRepository, AdminRepository>();
            services.AddDbContext<HRBSContext>(o => o.UseSqlite("Data source=HRBS.db"));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("V1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "HRBAPI", Version = "V1" });
            });
                
        }
    }
}
