using Microsoft.EntityFrameworkCore;
using Staff.Data.Context;

namespace Staff.WebAPI.Extensions
{
    public static class DbContextExtension
    {
        public static void AddDbContextExtension(this IServiceCollection services, IConfiguration configuration)
        {
            var dbType = configuration.GetConnectionString("SqlServer");
            services.AddDbContext<StaffDbContext>(options =>
            {
                options.UseSqlServer(dbType);
            });
        }
    }
}